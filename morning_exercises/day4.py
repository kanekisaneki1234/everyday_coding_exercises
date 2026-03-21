def twoSum(nums: list, target: int)->list:
    res = []
    seen = {}

    if (len(nums)==0): return []

    for i in range(0, len(nums)):
        complement = target - nums[i]

        if(complement in seen): res.append([seen[complement], i])

        seen[nums[i]] = i

    return res

print(twoSum([1,2,3,4],5))