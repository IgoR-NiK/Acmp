#include <iostream>
#include <string>
#include <vector>
#include <optional>

// ALT - Acmp Lib Testing
namespace alt {

using TaskLogicFunc = void(*)(std::istream &, std::ostream &);

class Testing {
public:
    constexpr static const char* EMPTY_OUTPUT = "!1@2#3$4%5^6&7*8(9)0_-+=";

    explicit Testing(TaskLogicFunc func);

    void addTest(std::string input, std::string output = EMPTY_OUTPUT);

    void run() const;

private:
    using _IOPair = std::pair<std::string, std::string>;
    using _IOPairVec = std::vector<_IOPair>;

    TaskLogicFunc m_func = nullptr;
    _IOPairVec m_ioTestList;
};

}
