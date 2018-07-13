#include "../solution.h"

// BEGIN COPY SELECTION

#include <set>
#include <algorithm>
#include <cstddef>

void solution(std::istream &IS, std::ostream &OS) {
    //
    //  FIXME Ошибка на 7м тесте
    //

    uint32_t N, M;
    IS >> N >> M;

    std::set<uint16_t> a, b, c;
    uint16_t t;
    for (; N--; IS >> t, a.insert(t));
    for (; M--; IS >> t, b.insert(t));

    std::set_intersection(a.begin(), a.end(), b.begin(), b.end(), std::inserter(c, c.begin()));

    for (auto &v : c)
        OS << v << " ";
}