#include "../solution.h"

// BEGIN COPY SELECTION

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

void solution(std::istream &I, std::ostream &O) {
    uint32_t N, L = 0;
    uint16_t K;
    // Кол-во лампочек и инверсий
    I >> N >> K;
    // Периоды инверсий
    vector<Period> p(K);
    for (auto &pk : p)
        I >> pk.step;
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

    O << L;
}