# def mergeIntervals(input: list, output: list):
#     min = float('-inf')
#     # for i in input:
#     #     i[0]
    

# def mergeSort(lst: list)->list:
#     mid = len(lst)//2
#     print(f"mid: {mid}")
#     if mid==0: return lst
#     left = mergeSort(lst[0:mid])
#     print(f"left: {left}")
#     right = mergeSort(lst[mid:len(lst)])
#     print(f"right: {right}")

#     i = j = k = 0
#     while (i<len(left) and j<len(right)):
#         if left[i]<right[j]:
#             lst[k]=left[i]
#             i+=1
#             k+=1
#         elif right[j]<left[i]:
#             lst[k] = right[j]
#             j+=1
#             k+=1

#     while i < len(left):
#         lst[k] = left[i]
#         i += 1
#         k += 1

#     while j < len(right):
#         lst[k] = right[j]
#         j += 1
#         k += 1

#     return lst

# # arr = [1,2,4,3]
# # res = mergeSort(arr)
# # print(res)

# def mergeSortInline(arr: list, left, right):
#     if (left>=right): return

#     mid = (left+right)//2

#     mergeSortInline(arr, left, mid)
#     mergeSortInline(arr, mid+1, right)

#     i = left
#     j = mid+1

#     while (i<=mid and j<=right):
#         if (arr[i]<=arr[j]):
#             i+=1
#         else:
#             temp = arr[j]
#             k = j
#             while (k > i):
#                 arr[k]=arr[k-1]
#                 k-=1
#             arr[i]=temp
#             j+=1
#             i+=1

# arr=[2,3,1,5]
# mergeSortInline(arr, 0, 3)
# print(arr)

def mergeIntervals(intervals: list):
    def sortIntervals(intervals, left, right):
        if left >= right: return

        mid = (left + right)//2

        sortIntervals(intervals, left, mid)
        sortIntervals(intervals, mid+1, right)

        i=left
        j=mid+1

        while (i<=mid and j<=right):
            if (intervals[i][0]<=intervals[j][0]): i+=1

            else:
                temp = intervals[j]
                k=j
                while (k>i):
                    intervals[k]=intervals[k-1]
                    k-=1
                intervals[i]=temp
                i+=1
                j+=1
        return intervals
    if len(intervals)<=1: return intervals
    sorted_intervals = sortIntervals(intervals, 0, len(intervals)-1)
    print(sorted_intervals)

    # i, j = 0, 1
    # while (i<len(sorted_intervals)):
    #     while (j<len(sorted_intervals)):
    #         # if sorted_intervals[i][1]>=sorted_intervals[j][1]:
    #         #     sorted_intervals.pop(j)
    #         # elif ((sorted_intervals[i][1]>=sorted_intervals[j][0] and (sorted_intervals[i][1]<=sorted_intervals[j][1]))):
    #         #     sorted_intervals[i] = [sorted_intervals[i][0], sorted_intervals[j][1]]
    #         #     sorted_intervals.pop(j)
    #         # else: 
    #         #     j+=1
    #         if sorted_intervals[i][1]>=sorted_intervals[j][0]:
    #             sorted_intervals[i] = [sorted_intervals[i][0], max(sorted_intervals[i][1], sorted_intervals[j][1])]
    #             sorted_intervals.pop(j)
    #         else:
    #             j+=1
    #     i+=1
    #     return sorted_intervals

    result = [sorted_intervals[0]]
    # print(result)

    for i in range(1,len(sorted_intervals)):
        print(sorted_intervals[i][0])
        if result[-1][1]>=sorted_intervals[i][0]:
            result[-1][1]=max(result[-1][1], sorted_intervals[i][1])
        else:
            result.append(sorted_intervals[i])
            # print(result)
    
    return result
    

    # return sortIntervals(intervals, 0, len(intervals)-1)
# print(mergeIntervals([[4,5], [5,6], [6,7]]))
# Basic overlap
print(mergeIntervals([[1,3],[2,6],[8,10],[15,18]]))  # [[1,6],[8,10],[15,18]]

# Unsorted input
# print(mergeIntervals([[2,6],[1,3],[15,18],[8,10]]))  # [[1,6],[8,10],[15,18]]

# # One interval fully contains another
# print(mergeIntervals([[1,10],[2,5]]))                # [[1,10]]

# # Touching at a single point
# print(mergeIntervals([[1,4],[4,5]]))                 # [[1,5]]

# # No overlaps at all
# print(mergeIntervals([[1,2],[3,4],[5,6]]))           # [[1,2],[3,4],[5,6]]

# # All intervals merge into one
# print(mergeIntervals([[1,4],[2,6],[3,8]]))           # [[1,8]]

# # Single interval
# print(mergeIntervals([[3,7]]))                       # [[3,7]]