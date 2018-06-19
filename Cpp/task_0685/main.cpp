#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector<uint16_t> a(3), b(3);
    std::cin >> a[0] >> a[1] >> a[2] >> b[0] >> b[1] >> b[2];
    std::sort(a.begin(), a.end());
    std::sort(b.begin(), b.end());
    std::cout << a[0] * b[0] + a[1] * b[1] + a[2] * b[2];
}