class SlidingWindow
{
    public static string LongestSubstring(string input)
    {
        int left = 0; int right = 0; int maxVal = 0; int maxRight=0; int maxLeft=0;

        Dictionary<char, int> hashset = [];
        while (left<input.Length && right< input.Length)
        {
            if (hashset.GetValueOrDefault(input[right], 0) > 0)
            {
                hashset[input[left]]--;
                left++;
            }
            else
            {
                if ((right-left)>=maxVal) 
                {
                    maxVal=right-left;
                    maxLeft = left;
                    maxRight = right+1;
                }
                hashset[input[right]] = hashset.GetValueOrDefault(input[right], 0) + 1;
                right+=1;
            }
        }
        return input[maxLeft..maxRight];
    }
}