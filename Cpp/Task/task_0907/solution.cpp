#include "../solution.h"

// BEGIN COPY SELECTION

#include <iostream>
#include <algorithm>

void solution(std::istream &is, std::ostream &os) {
    uint32_t w, h, r;
    is >> w >> h >> r;
    if (2*r <= std::min(w, h))
        os << "YES";
    else
        os << "NO";
}