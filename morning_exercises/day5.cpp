#include <stack>
#include <string>
#include <iostream>

bool isValid(std::string input) {
    std::stack<char> openings;

    for (int i=0; i<input.length(); i++) {
        if (input[i]=='(' || input[i]=='{' || input[i]=='[') openings.push(input[i]);
        else {
            if (openings.empty()) return false;

            if (input[i]==')' && openings.top()=='(') openings.pop();
            else if (input[i]=='}' && openings.top()=='{') openings.pop();
            else if (input[i]==']' && openings.top()=='[') openings.pop();
            else return false;
        }
    }
    return openings.empty();
}

int main() {
    std::cout << std::boolalpha;
    std::cout << isValid("{{]}}") << "\n";
    std::cout << isValid("()[]{}") << "\n";
    std::cout << isValid("{[]}") << "\n";
}