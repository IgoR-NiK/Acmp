#include "../solution.h"

// BEGIN COPY SELECTION

#include <array>
#include <algorithm>

void solution(std::istream &ins, std::ostream &outs) {
    std::array<uint16_t, 3> a, b;
    ins >> a[0] >> a[1] >> a[2] >> b[0] >> b[1] >> b[2];
    std::sort(a.begin(), a.end());
    std::sort(b.begin(), b.end());
    outs << a[0] * b[0] + a[1] * b[1] + a[2] * b[2];
}