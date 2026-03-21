#include <iostream>
#include <ostream>

bool isPalindrome(int n) {
    if (n < 0) return false;

    int temp_num = n; int pal_check = 0;

    while (temp_num>0) {
        int last_digit=temp_num%10;
        pal_check=pal_check*10+last_digit;
        temp_num=temp_num/10;
    }
    return n==pal_check;
}

int main() {
    std::cout << std::boolalpha;
    std::cout << isPalindrome(91) << std::endl;  // true
}