// 168ms, 75.58%, 10m, 3t
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {        
        int mnc = 0;
        int nc = 0;
        for (int i = 0; i < nums.Length; ++i){
            if (nums[i] == 1){
                ++nc;
            }
            else{
                mnc = Math.Max(mnc, nc);
                nc = 0;
            }
        }
        
        mnc = Math.Max(mnc, nc);
        return mnc;
    }
}