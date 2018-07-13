# ========== [ Определение теста ] ==========
function(acmp_find_test taskNumber targetTaskLib)

    set(testName "test_${taskNumber}")
    set(testFile "${ACMP_CPP_TEST_DIR}/${testName}.cpp")
    set(testFindResultVarName FIND_${taskNumber}_RESULT)

    if (EXISTS ${testFile})
        set(target "acmp_${testName}")
        project(${target})
        add_executable(${target}
                       "${ACMP_CPP_TEST_DIR}/common/test.h"
                       ${testFile}
                       "${ACMP_CPP_TEST_DIR}/common/main.cpp")

        target_include_directories(${target} PRIVATE
                                   "${ACMP_CPP_LIB_TESTING_DIR}/"
                                   "${ACMP_CPP_TASK_DIR}/")
        target_link_libraries(${target} PRIVATE
                              ${ACMP_CPP_LIB_TESTING_TARGET}
                              ${targetTaskLib})

        set(${testFindResultVarName} ${testName} PARENT_SCOPE)
    else ()
        set(${testFindResultVarName} null PARENT_SCOPE)
    endif ()

endfunction(acmp_find_test)

# ========== [ Добавление задач ] ==========
function(acmp_define_tasks)

    file(GLOB taskDirList "${ACMP_CPP_TASK_DIR}/task_*")

    string(LENGTH
           "${ACMP_CPP_TASK_DIR}/" taskDirPathLength)

    message(STATUS "========== [DEFINE TASKS] ==========")
    foreach (taskDir ${taskDirList})
        string(SUBSTRING
               ${taskDir}
               ${taskDirPathLength}
               9 # length of "task_XXXX"; XXXX -- task number
               taskDirShortName)
        string(SUBSTRING
               ${taskDirShortName}
               5 4
               taskNumber)

        set(targetSrc
            "${ACMP_CPP_TASK_DIR}/solution.h"
            "${taskDir}/solution.cpp")

        # exe
        set(targetExeName "acmp_${taskDirShortName}")
        project(${targetExeName})
        add_executable(${targetExeName}
                       ${targetSrc}
                       "${ACMP_CPP_TASK_DIR}/main.cpp")

        # lib
        set(targetLibName "acmp_${taskDirShortName}_lib_test")
        project(${targetLibName})
        add_library(${targetLibName} STATIC
                    ${targetSrc})

        # test
        acmp_find_test(${taskNumber} ${targetLibName})

        # result
        message(STATUS "EXE: ${targetExeName}          LIB: ${targetLibName}          TEST: ${FIND_${taskNumber}_RESULT}")
    endforeach (taskDir)
    message(STATUS "====================================")

endfunction(acmp_define_tasks)
