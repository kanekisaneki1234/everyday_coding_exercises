"use strict";
function twoSum(nums, target) {
    let res = [];
    if (nums.length === 0)
        return [];
    for (let i = 0; i < nums.length; i++) {
        for (let j = i + 1; j < nums.length; j++) {
            if ((nums[i] + nums[j]) == target)
                res.push([i, j]);
        }
    }
    return res;
}
// console.log(twoSum([1,2,3,4], 5));
function twoSumOptimal(nums, target) {
    let res = [];
    const seen = new Map();
    if ((nums.length) === 0)
        return [];
    for (let i = 0; i < nums.length; i++) {
        const compliment = target - nums[i];
        if (seen.has(compliment))
            res.push([(seen.get(compliment)), i]);
        seen.set(nums[i], i);
    }
    return res;
}
console.log(JSON.stringify(twoSumOptimal([1, 2, 3, 4], 5)));
//# sourceMappingURL=day4.js.map