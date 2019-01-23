// 112ms, 62.33%, 10m, 2t
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;
        
        int s = 0, e = 0, p = 0;
        for (int i = 1; i < prices.Length; ++i){
            if (prices[i] > prices[e]){
                e = i;
                p = Math.Max(p, prices[e] - prices[s]);
            }
            else if (prices[i] <= prices[s]){
                s = i;
                e = i;
            }                           
        }
        
        return p;
    }
}