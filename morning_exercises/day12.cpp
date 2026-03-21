#include <vector>
#include <iostream>

int binarySearch(std::vector<int> input, int left, int right, int val) {
    if (left>right) return -1;
    int mid = (left+right)/2;
    if (val == input[mid]) return mid;
    else if (val<input[mid]) return binarySearch(input, left, mid-1, val);
    return binarySearch(input, mid+1, right, val);
}

int main() {
    std::vector<int>input = {1,2,3,4,5,6,7,8,9,10};
    std::cout << binarySearch(input, 0, 9, 9);
}