public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;
        for(int i = 1; i <= prices.Length - 1; i++) {
            int curProfit = prices[i] - minPrice;
            maxProfit = Math.Max(maxProfit, curProfit);
            minPrice = Math.Min(minPrice, prices[i]);
        }
        return maxProfit;
    }
}
