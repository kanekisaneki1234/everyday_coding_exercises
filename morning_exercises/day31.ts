function longestSubstring(input: string): string {
    let left = 0, right = 0, maxVal = 0, maxLeft = 0, maxRight = 0;
    const map = new Map<string, number>();

    while (left<input.length && right<input.length) {
        if ((map.get(input[right]) ?? 0)>0) {
            map.set(input[left], map.get(input[left])! - 1)
            left++;
        }
        else {
            if ((right-left)>=maxVal) {
                maxVal=right-left;
                maxLeft=left; maxRight = right;
            } 
            map.set(input[right], (map.get(input[right]) ?? 0)!+1)
            right++;
        }
    }
    return input.substring(maxLeft,maxRight+1);
}

console.log(longestSubstring("abcabcbb")); // "abc"
console.log(longestSubstring("bbbbb"));    // "b"
console.log(longestSubstring("pwwkew"));   // "wke"
console.log(longestSubstring("abcdef"));   // "abcdef"
console.log(longestSubstring("aab"));      // "ab"
console.log(longestSubstring("dvdf"));     // "vdf"
console.log(longestSubstring("a"));        // "a"
console.log(longestSubstring(""));         // ""