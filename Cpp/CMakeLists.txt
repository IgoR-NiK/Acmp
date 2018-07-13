#
# Корень CMake-проекта
#
cmake_minimum_required(VERSION 3.10)

include(common.cmake)
set(ACMP_CPP_TASK_DIR "${CMAKE_CURRENT_SOURCE_DIR}/Task")
set(ACMP_CPP_TEST_DIR "${CMAKE_CURRENT_SOURCE_DIR}/Test")
set(ACMP_CPP_LIB_TESTING_DIR "${ACMP_CPP_TEST_DIR}/libTesting")
set(ACMP_CPP_LIB_TESTING_TARGET acmp_lib_testing)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -static")   # Статическая линковка стандартной библиотеки std GCC

# Добавление вспомогательной библиотеки
add_subdirectory("${ACMP_CPP_LIB_TESTING_DIR}/")
message(STATUS "[+] libTesting added")

# Добавление задач
acmp_define_tasks()
