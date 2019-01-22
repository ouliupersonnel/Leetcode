// 868ms, 1.5%, 10m, 3t
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;
        
        int[] profit = new int[prices.Length];
        for (int i = prices.Length - 2; i >= 0; --i){
            int bestWhenBuyI = 0;
            for (int j = i+1; j < prices.Length; ++j){
                if (prices[j] > prices[i]){
                    bestWhenBuyI = profit[j] + prices[j] - prices[i];  
                    break;
                }
            }
            profit[i] = Math.Max(profit[i+1], bestWhenBuyI);
        }
        
        return profit[0];
    }    
}