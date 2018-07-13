project(${ACMP_CPP_LIB_TESTING_TARGET})
add_library(${ACMP_CPP_LIB_TESTING_TARGET} STATIC
            testing.h testing.cpp ../../Task/main.cpp)
