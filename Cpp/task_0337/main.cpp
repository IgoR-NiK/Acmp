#include <iostream>
#include <sstream>
#include <vector>
#include <cstdint>
#include <algorithm>

using namespace std;
#define U64(x) static_cast<uint64_t>(x)
#define U32(x) static_cast<uint32_t>(x)
#define U16(x) static_cast<uint16_t>(x)

struct Period {
    // Смещение
    uint16_t offset = 0;
    // Значение периода (постоянное)
    uint16_t value = 0;

    bool operator==(const Period &rhs) const {
        return offset == rhs.offset &&
               value == rhs.value;
    }

    bool operator<(const Period &rhs) const {
        return value < rhs.value;
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
        ins >> pk.value;
    // Сортировка
    auto pi = p.begin();
    sort(pi, p.end());
    // Отсеивание парных
    while ((pi = adjacent_find(pi, p.end())) != p.end())
        p.erase(pi, ++pi);
    // Покадровое переключение лампочек
    while (N > 0) {
        // Битовый кадр и длина
        uint64_t lampsBitFrame = 0;
        auto frameLength = U16(min(N, U32(p.back().value)));
        // Переключение лампочек согласно данным периода
        for (auto &pk : p) {
            // Переключение пока в пределах кадра
            do lampsBitFrame ^= U64(1) << pk.offset;
            while ((pk.offset += pk.value) <= frameLength);
            // Ограничение смещение в пределах кадра
            pk.offset %= frameLength;
        }

        while (lampsBitFrame > U64(0))
            L += (lampsBitFrame >>= U64(1)) & U64(1);

        N -= frameLength;
    }

    outs << L;
}

void test(const char *input) {
    stringstream ex;
    ex << input;
    cout << "IN: " << input << "OUT: ";
    run(ex, cout);
    cout << "\n\n";
}

int main() {
    // FIXME Wrong Answer on test 5 (8466247)

    test("20 3 \n 2 3 8 \n");
    test("172 10 \n 19 2 7 13 40 23 16 1 45 9 \n");
    test("1000000000 4 \n 17 13 31 43 \n");
    run(cin, cout);
}