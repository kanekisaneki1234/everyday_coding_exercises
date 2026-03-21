#include <iostream>
#include <unordered_map>
#include <vector>

std::vector<std::vector<int>> twoSum(std::vector<int>& nums, int target) {
    std::vector<std::vector<int>> res;
    std::unordered_map<int, int> seen;

    if(nums.size()==0) return res;

    for (int i=0;i<nums.size();i++) {
        const int complement = target - nums [i];

        if(seen.count(complement)) res.push_back({seen.at(complement), i});

        seen[nums[i]]=i;
    }
    return res;
}

int main() {
    std::vector<int> nums = {1,2,3,4};

    auto res = twoSum(nums, 5);
    for (const auto& pair : res) std::cout << "[" << pair[0] << "," << pair[1] << "]\n";
}