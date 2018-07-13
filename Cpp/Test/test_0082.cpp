#include "common/test.h"

void test(alt::Testing &t) {
    t.addTest("11 6\n2 4 6 8 10 12 10 8 6 4 2\n3 6 9 12 15 18", "6 12");
    t.addTest("5 5\n1 5 3 9 7\n8 4 6 2 0", "");
    t.addTest("0 2\n\n1 5", "");
    t.addTest("2 0\n9 2\n", "");
    t.addTest("5 5\n3 4 2 1 8\n1 8 4 3 2", "1 2 3 4 8");
    t.addTest("7 3\n5 5 5 5 5 5 5\n9 2 5", "5");
    t.addTest("1 1\n7\n3", "");
    t.addTest("1 1\n4\n4", "4");
}

