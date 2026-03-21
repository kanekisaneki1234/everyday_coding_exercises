using System.Globalization;

public static class FindDuplicates
{
    public static bool containsDuplicates(List<int> nums)
    {
        var seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num)) return true;
            seen.Add(num);
        }
        return false;
    }
}