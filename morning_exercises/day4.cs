public static class TwoSumOptimal
{
    public static List<List<int>> twoSum(List<int> nums, int target)
    {
        List<List<int>> res = [];
        Dictionary <int, int> seen = [];

        if (nums.Count==0) return [];

        for (int i=0; i<nums.Count; i++)
        {
            int complement = target - nums[i];

            if (seen.TryGetValue(complement, out int value)) res.Add(new List<int> {value, i});

            seen[nums[i]] = i;
        }
        return res;
    }
}