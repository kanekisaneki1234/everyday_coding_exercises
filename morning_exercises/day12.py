def binarySearch(input: list, left: int, right: int, val: int)->int:
    if (left>right): return -1
    mid = (left+right)//2
    if (input[mid]==val): return mid
    elif (val<input[mid]): return binarySearch(input, left, mid-1, val)
    else: return binarySearch(input, mid+1, right, val)

print(binarySearch([2,3,4,5,6,7,8,9,10], 0, 9, 7))