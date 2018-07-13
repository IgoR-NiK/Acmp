#include <solution.h>

#include "test.h"

int main() {
    alt::Testing t(solution);
    test(t);
    t.run();
    return 0;
}