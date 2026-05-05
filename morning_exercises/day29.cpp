#include <iostream>
#include <ostream>
#include <vector>

int binarySearchHelper(std::vector<int>& nums, int target, int left, int right) {
    int mid = (left + right)/2;
    // std::cout << mid << "\n";
    // std::cout << left << "\n";
    // std::cout << right << "\n";
    
    if (left>=right) {
        if (target>nums[nums.size()-1]) return nums.size();
        return mid;
    }
    int result;

    if (target<nums[mid]) {
        result = binarySearchHelper(nums, target, left, mid);
    }
    else if (target>nums[mid]) {
        result = binarySearchHelper(nums, target, mid+1, right);
    }
    else if (target==nums[mid]) {
        result = mid;
    }
    return result;
}

int binarySearch(std::vector<int>& nums, int target) {
    int left = 0; int right = nums.size()-1;
    return binarySearchHelper(nums, target, left, right);
}

int binarySearchCleaner(std::vector<int>& nums, int target) {
    int left = 0; int right = nums.size()-1;

    while (left<=right) {
        int mid = (left+right)/2;
        if (target<nums[mid]) right = mid;
        else if (target>nums[mid]) left = mid+1;
        else if (target==nums[mid]) return mid;
    }
    return left;
}

// int binarySearchCleaner(std::vector<int>& nums, int target) {
//     int left = 0; int right = nums.size()-1;

//     while (left<=right) {
//         int mid = (left+right)/2;
//         if (target==nums[mid]) return mid;
//         else if (target<nums[mid]) right = mid-1;
//         else left = mid+1;
//     }
//     return left;
// }

int main() {
    std::vector<int> nums = {1, 2,3, 4};
    int target = 5;
    // std::cout << binarySearch(nums, target) << std::endl;
    std::cout << binarySearchCleaner(nums, target);
}