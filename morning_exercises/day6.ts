function maxProfit(prices: number[]): number {
    let minPrice = Number.MAX_VALUE, maxProfit = 0;

    prices.forEach(price => {
        minPrice = Math.min(minPrice, price);
        maxProfit = Math.max(maxProfit, price - minPrice);
    });
    
    return maxProfit;
}

console.log(maxProfit([1,2,3,4,5]));