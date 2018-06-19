#
# root cmake-project
#

cmake_minimum_required(VERSION 3.10)
project(acmp_cpp)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -static")   # static link GCC standart library

file(GLOB ACMP_TASK_DIRS "task_*")

message(STATUS "===== TASKS ADDING =====")
foreach (task_dir_full_name ${ACMP_TASK_DIRS})
    add_subdirectory(${task_dir_full_name})
    string(LENGTH
           ${CMAKE_CURRENT_SOURCE_DIR} project_path_length)
    string(SUBSTRING
           ${task_dir_full_name}
           ${project_path_length}
           10 # length of "tast_XXXX"; XXXX -- task number
           task_dir_short_name)

    message(STATUS "${task_dir_short_name} -- added")
endforeach (task_dir_full_name)
message(STATUS "========================")