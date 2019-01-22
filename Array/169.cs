// 132ms, 94.66%, 10m, 1t
public class Solution {
    public int MajorityElement(int[] nums) {
        int r = 0;
        int c = 0;
        
        for (int i = 0; i < nums.Length; ++i){
            if (c == 0){
                r = nums[i];
                ++c;
            }
            else{
                if (nums[i] == r)
                    ++c;                
                else 
                    --c;                
            }
        }
        
        return r;
    }
}