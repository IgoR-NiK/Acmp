#include "common/test.h"

void test(alt::Testing &t) {
    t.addTest("20 3 \n 2 3 8 \n", "8");
    t.addTest("172 10 \n 19 2 7 13 40 23 16 1 45 9 \n", "99");
//    stringstream num;
//    for (int i = 1; i <= 50; i++)
//        num << i << " ";
//    test("100000 50 \n " + num.str() + " \n");
//    test("171 10 \n 19 2 7 13 40 23 16 1 45 9 \n");
    t.addTest("171 5 \n 19 2 7 13 40 \n", "79");
    t.addTest("172 5 \n 19 2 7 13 40 \n", "80");
    t.addTest("171 6 \n 19 2 7 13 40 1\n", "93");
    t.addTest("172 6 \n 19 2 7 13 40 1\n", "92");
}

