public static class Palindrome
{
    public static bool IsPalindrome(int n)
    {
        if (n<0) return false;

        int palCheck = 0, temp = n;

        while (temp>0)
        {
            int lastDigit = temp%10;
            palCheck=palCheck*10+lastDigit;
            temp/=10;
        }

        return palCheck==n;
    }
}