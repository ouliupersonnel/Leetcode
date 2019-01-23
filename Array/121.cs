// 108ms, 82.90%, 10m, 2t
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;
        
        int s = 0, ev = prices[0], p = 0;
        for (int i = 1; i < prices.Length; ++i){
            if (prices[i] > ev){
                ev = prices[i];                
            }
            else if (prices[i] <= prices[s]){
                p = Math.Max(p, ev - prices[s]);
                s = i;
                ev= prices[i];                
            }                           
        }
        
        return Math.Max(p, ev - prices[s]);
    }
}