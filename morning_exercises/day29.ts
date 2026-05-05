function binarySearch(nums: number[], target: number): number {
    let left = 0; let right = nums.length-1;

    while (left<=right) {
        let mid = Math.floor((left+right)/2);
        if (target===nums[mid]) return mid;
        else if (target<nums[mid]) right = mid-1;
        else left = mid+1;
    }
    return left;
}

{
    let nums = [1,2,3,4,5];
    let target = 1;
    console.log(binarySearch(nums, target));
}