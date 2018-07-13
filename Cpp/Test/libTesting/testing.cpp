#include "testing.h"

#include <sstream>

namespace tool {

void trim(std::string &src) {
    auto i = src.begin();
    for (; i != src.end(); i++) {
        char c = *i;
        if (!(c == ' ' || c == '\n' || c == '\t' || c == '\r')) break;
    }
    // Удаление
    src.erase(src.begin(), i);

    auto j = src.rbegin();
    for (; j != src.rend(); j++) {
        char c = *j;
        if (!(c == ' ' || c == '\n' || c == '\t' || c == '\r')) break;
    }
    // Удаление
    src.erase(j.base(), src.rbegin().base());
}

}

namespace alt {

Testing::Testing(TaskLogicFunc func)
    : m_func(func) { }

void Testing::addTest(std::string input, std::string output) {
    tool::trim(input);
    tool::trim(output);
    m_ioTestList.emplace_back(input, output);
}

void Testing::run() const {
    uint32_t testCounter = 0;

    for (auto &p : m_ioTestList) {
        std::stringstream iss, oss;
        iss << p.first;

        std::cout << "TEST " << ++testCounter << " -- ";

        try {
            (*m_func)(iss, oss);
        } catch (...) {
            std::cout << "except";
            continue;
        }

        std::string result = oss.str();
        tool::trim(result);

        if (p.second != EMPTY_OUTPUT) {
            if (result == p.second)
                std::cout << "done";
            else
                std::cout << "fail\n"
                          << "[ INPUT ]\n" << p.first << "\n"
                          << "[ EXPECTED ]\n" << p.second << "\n"
                          << "[ RECEIVED ]\n" << result;
        } else {
            std::cout << "empty";
        }

        std::cout << "\n";
    }
}

}
