def maxProfit(prices: list)->int:
    minPrice = float('inf')
    maxProfit = 0

    for price in prices:
        minPrice  = min(minPrice, price)
        maxProfit = max(maxProfit, price - minPrice)

    return maxProfit

print(maxProfit([6,1,2,1]))