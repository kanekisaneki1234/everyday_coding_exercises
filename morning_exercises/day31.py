from collections import defaultdict

def longestSubstring(input: str)->str:
    hashset = defaultdict(int)
    left, right, maxLength = 0, 0, float('-inf')

    while left<len(input) and right<len(input):
        if hashset.get(input[right], 0)>0:
            hashset[input[left]]-=1
            left+=1
        else:
            hashset[input[right]]+=1
            right+=1
            if (right - left)>=maxLength:
                maxLength = right - left
                maxRight = right
                maxLeft = left

    return input[maxLeft:maxRight]

# input = "bbbbb"
# print(longestSubstring(input))

print(longestSubstring("abcabcbb"))  # "abc" - length 3
print(longestSubstring("bbbbb"))     # "b" - length 1
print(longestSubstring("pwwkew"))    # "wke" - length 3
# print(longestSubstring(""))          # "" - empty string
print(longestSubstring("abcdef"))    # "abcdef" - no duplicates, whole string
print(longestSubstring("aab"))       # "ab" - length 2
print(longestSubstring("dvdf"))      # "vdf" - length 3
print(longestSubstring("a"))         # "a" - single character