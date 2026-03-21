function twoSum(nums: number[], target: number): number[][] {
    let res: number[][]=[];
    if (nums.length===0) return []

    for(let i = 0; i<nums.length; i++) {
        for(let j = i+1; j<nums.length; j++) {
            if ((nums[i]+nums[j])==target) res.push([i,j]);
        }
    }
    return res
}

// console.log(twoSum([1,2,3,4], 5));

function twoSumOptimal(nums: number[], target: number): number[][] {
    let res:number[][]=[];
    const seen = new Map<number, number>();

    if ((nums.length)===0) return [];

    for (let i=0;i<nums.length; i++) {
        const compliment = target - nums[i]!;

        if (seen.has(compliment)) res.push([(seen.get(compliment)!),i]);
        seen.set(nums[i]!,i);
    }
    return res;
}

console.log(JSON.stringify(twoSumOptimal([1,2,3,4], 5)));