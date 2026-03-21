def containsDuplicates(nums: list)->bool:
    seen = set()

    for num in nums:
        if num in seen: return True
        seen.add(num)
    
    return False

# print(containsDuplicates([1,2,3,4,1]))

def containsDuplicateCleanest(nums: list) -> bool:
    return len(nums) != len(set(nums))

print(containsDuplicateCleanest([1,2,3,4,1]))