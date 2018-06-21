#include <iostream>
#include <vector>
#include <cstdint>
#include <algorithm>

#include <sstream>

using namespace std;

struct Period {
    // Смещение
    uint16_t pos = 0;
    // Значение периода (постоянное)
    uint16_t step = 0;

    bool operator==(const Period &rhs) const {
        return pos == rhs.pos &&
               step == rhs.step;
    }

    bool operator<(const Period &rhs) const {
        return step < rhs.step;
    }
};

void run(istream &ins, ostream &outs) {
    uint32_t N, L = 0;
    uint16_t K;
    // Кол-во лампочек и инверсий
    ins >> N >> K;
    // Периоды инверсий
    vector<Period> p(K);
    for (auto &pk : p)
        ins >> pk.step;
    // Сортировка
    sort(p.begin(), p.end());
    // Отсеивание парных
    for (;;) {
        auto pi = adjacent_find(p.begin(), p.end());
        if (pi == p.end()) break;
        p.erase(pi, pi + 2);
    }
    // Покадровое переключение лампочек
    while (N > 0) {
        // Битовый кадр и длина
        uint64_t lampsBitFrame = 0;
        auto frameLength = min(N, uint32_t(p.back().step));

        // Переключение лампочек согласно данным периода
        for (auto &pk : p) {
            // Переключение пока в пределах кадра
//            for (; pk.pos <= frameLength; pk.pos += pk.step)
//                lampsBitFrame ^= uint64_t(1) << uint8_t(pk.pos);
            while ((pk.pos += pk.step) < frameLength) {
                pk.pos += pk.step;
                lampsBitFrame ^= uint64_t(1) << uint8_t(pk.pos);
            }
            // Ограничение смещение в пределах кадра
            pk.pos %= frameLength;
        }

        while (lampsBitFrame > 0)
            L += (lampsBitFrame >>= 1) & uint64_t(1);

        N -= frameLength;
    }

    outs << L;
}

void test(const std::string &input, const std::string &output = "") {
    static uint32_t testCounter = 0;

    stringstream ss;
    ss << input;
    cout << " ==== TEST " << ++testCounter << " ==== \n";
    cout << "IN: " << input << "OUT: ";

    run(ss, ss);

    std::string result;
    ss >> result;
    cout << result;
    if (!output.empty()) {
        cout << " - ";
        if (result == output)
            cout << "DONE!";
        else
            cout << "FAIL! (Not equal '" << output << "')";
    }
    cout << "\n\n";
}

void tests() {
    test("20 3 \n 2 3 8 \n", "8");
    test("172 10 \n 19 2 7 13 40 23 16 1 45 9 \n", "99");
//    stringstream num;
//    for (int i = 1; i <= 50; i++)
//        num << i << " ";
//    test("100000 50 \n " + num.str() + " \n");
//    test("171 10 \n 19 2 7 13 40 23 16 1 45 9 \n");
    test("171 5 \n 19 2 7 13 40 \n", "79");
    test("172 5 \n 19 2 7 13 40 \n", "80");
    test("171 6 \n 19 2 7 13 40 1\n", "93");
    test("172 6 \n 19 2 7 13 40 1\n", "92");
}

int main() {
    tests();
//    run(cin, cout);
}