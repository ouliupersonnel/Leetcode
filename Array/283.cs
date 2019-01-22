// 292ms, 94.24%, 5m, 1t
public class Solution {
    public void MoveZeroes(int[] nums) {
        int l = -1;
     for (int i = 0; i < nums.Length; ++i){
         if (nums[i] != 0){
             if (i != l +1){
                 nums[l+1] = nums[i];
                 nums[i]=0;                 
             }
             ++l;
         }
     }   
    }
}