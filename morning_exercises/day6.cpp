#include <climits>
#include <vector>
#include <iostream>

int maxProfit(std::vector<int>& prices) {
    int minPrice = INT_MAX, maxProfit = 0, profit = 0;

    for (int i=0;i<prices.size(); i++) {
        if(prices[i]<minPrice) minPrice=prices[i];

        profit=prices[i]-minPrice;

        if (profit>maxProfit) maxProfit=profit;
    }
    return maxProfit;
}

int maxProfitCleaner(std::vector<int>& prices) {
    int minPrice = INT_MAX, maxProfit = 0;

    for (int price : prices) {
        minPrice = std::min(minPrice, price);

        maxProfit = std::max(maxProfit, price - minPrice);
    }
    return maxProfit;
}

int main() {
    std::vector<int> prices = {20,1,4,2};
    std::cout << maxProfitCleaner(prices);
}