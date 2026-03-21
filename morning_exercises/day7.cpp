#include <unordered_set>
#include <iostream>
#include <vector>

bool containsDuplicate(std::vector<int> nums) {
    std::unordered_set<int> seen;

    for (int& num : nums) {
        if (seen.count(num)) return true;
        else seen.insert(num);
    }
    return false;
}

int main() {
    std::cout << std::boolalpha;
    std::cout << containsDuplicate({1,2,2,4}) << "\n";
}