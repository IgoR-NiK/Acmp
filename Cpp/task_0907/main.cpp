#include <iostream>
#include <algorithm>

int main() {
    uint32_t w, h, r;
    std::cin >> w >> h >> r;
    if (2*r <= std::min(w, h))
        std::cout << "YES";
    else
        std::cout << "NO";
}