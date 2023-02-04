#include <iostream>
#define IMPORTED extern "C" __declspec(dllimport)
IMPORTED long int MyPlus(long int a, long int b);
int main(void) {
    std::cout << MyPlus(1L, 2L) << std::endl;
    return 0;
}
