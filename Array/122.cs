// 112ms, 54.99%, 20m, 2t
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;
        
        int s = 0, p = 0;
        for (int i = 1; i < prices.Length; ++i){
            if (prices[i] < prices[i-1]){
                p += prices[i-1] - prices[s];
                s = i;                
            }            
        }
        
        if (prices[prices.Length - 1] > prices[s])
            p += prices[prices.Length - 1] - prices[s];
        
        return p;
    } 
}