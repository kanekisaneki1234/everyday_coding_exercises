import math

def binarySearch(nums: list, target: int)->int:
    left, right = 0, len(nums)-1

    while (left<=right):
        mid = (left + right)//2

        if (target==nums[mid]): return mid
        elif (target<nums[mid]): right = mid-1
        else: left = mid+1
    return left

nums, target = [1,2,3,4,5], 0

# print(binarySearch(nums, target))

def binarySearchMatrix(input: list, target: int)->bool:
    left, right = 0, len(input)-1

    while left<=right:
        mid = (left + right)//2
        if (target==input[mid]): return True
        elif (target<input[mid]): right = mid - 1
        else: left = mid + 1

    return False

def binarySearchMatrixHelper(input: list)->list:
    output = []
    for row in input:
        output.extend(row)
    print(output)

    return output

matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]]
target = 3

# print(binarySearchMatrix(binarySearchMatrixHelper(matrix), target))

def binarySearchMatrixOptimal(input: list, target: int)->bool:
    m, n = len(input), len(input[0])
    
    left, right = 0, m*n-1

    while left<=right:
        mid = (left + right)//2
        val = input[mid//n][mid%n]
        if (target==val): return True
        elif (target<val): right = mid - 1
        else: left = mid + 1

    return False

# print(binarySearchMatrixOptimal(matrix, target))

def minBananas(piles: list, hours: int)->int:
    left = 1
    right = max(piles)

    while left<=right:
        mid = (left + right)//2
        total_hours = 0
        for pile in piles:
            total_hours+=math.ceil(pile/mid)
        
        # if total_hours==hours:
        #     return mid
        # elif total_hours<hours:
        #     right = mid - 1
        # else:
        #     left = mid + 1
        if total_hours <= hours: right = mid - 1
        else: left = mid + 1
    return left

# piles, h = [3,6,7,11], 8
# piles, h = [30,11,23,4,20], 5
# piles, h = [30,11,23,4,20], 6
# piles, h = [6,6], 4
piles, h = [3,6,7,11], 8

# print(minBananas(piles, h))

def minInRotated(input: list)->list:
    left, right = 0, len(input)-1
    while left<right:
        mid = (left+right)//2

        if input[mid]<=input[right]: right=mid
        else: left=mid+1
    return input[left]

nums = [5,6,7,8,0,1,2,3,4]
# print(minInRotated(nums))

def searchInRotated(input: list, target: int)->list:
    left, right = 0, len(input)-1

    while left<=right:
        mid = (left+right)//2

        if (input[mid]==target): return mid
        elif (input[mid]>=input[left]): 
            if (target>=input[left] and target<input[mid]): right = mid-1
            else: left = mid+1
        else:
            if (target>input[mid] and target<=input[right]): left = mid + 1
            else: right = mid-1
    return -1

nums, target = [4,5,6,7,0,1,2], 2
print(searchInRotated(nums, target))