public static class FindMaxProfit
{
    public static int MaxProfit(List<int> prices)
    {
        int minPrice = int.MaxValue, maxProfit = 0;

        foreach (int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }
        return maxProfit;
    }
}