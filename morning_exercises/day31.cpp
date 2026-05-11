#include <string>
#include <unordered_map>
#include <iostream>

std::string longestSubstring(std::string input) {
    int left = 0; int right = 0; int maxVal = 0; int maxLeft=0; int maxRight=0;
    std::unordered_map<char, int> map;

    while (left<input.size() && right<input.size()) {
        if (input.empty()) return "";

        if (map[input[right]]>0) {
            map[input[left]]--;
            left++;
        }
        else {
            if ((right-left)>=maxVal) {
                maxVal=right-left;
                maxLeft = left;
                maxRight = right;
            }
            map[input[right]]++;
            right++;
        }
    }
    return input.substr(maxLeft, maxVal+1);
}

int main() {
    std::cout << longestSubstring("abcabcbb") << std::endl; // "abc"
    std::cout << longestSubstring("bbbbb") << std::endl;    // "b"
    std::cout << longestSubstring("pwwkew") << std::endl;   // "wke"
    std::cout << longestSubstring("abcdef") << std::endl;   // "abcdef"
    std::cout << longestSubstring("aab") << std::endl;      // "ab"
    std::cout << longestSubstring("dvdf") << std::endl;     // "vdf"
    std::cout << longestSubstring("a") << std::endl;        // "a"
}