#include <iostream>
#include <vector>
#include <cstdint>
#include <algorithm>

using namespace std;

struct Period {
    uint16_t offset = 0;
    uint16_t value = 0;

    bool operator==(const Period &rhs) const {
        return offset == rhs.offset &&
               value == rhs.value;
    }

    bool operator<(const Period &rhs) const {
        return value < rhs.value;
    }
};

int main() {
    uint32_t N, framesCount = 0, lampsCount = 0;
    uint16_t K, pkMax;
    // Кол-во лампочек и инверсий
    cin >> N >> K;
    // Периоды инверсий
    vector<Period> p(K);
    for (auto &pk : p)
        cin >> pk.value;
    // Сортировка
    auto pi = p.begin();
    sort(pi, p.end());
    // Отсеивание парных
    while ((pi = adjacent_find(pi, p.end())) != p.end())
        p.erase(pi, ++pi);
    // Максимальный период
    pkMax = p.back().value;
    //
    uint32_t M = 0;
    while (M < N) {
        uint64_t lampBits = 0;
        auto frame = min(static_cast<uint16_t>(N - M), pkMax);
        cout << frame << "\n";
//        for (auto pk : p) {
//            uint16_t steps = 0;
//            while (steps < frame) {
//                steps += pk.offset + pk.value;
//                lampBits ^= (uint32_t(1) << steps);
//                pk.offset = steps % frame;
//            }
//        }
        M += frame;
    }

    for (auto i : p)
        cout << i.value << ' ';

    return 0;
}