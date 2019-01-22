// 372ms, 93.4%, 15m, 3t
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; ++i){
            int s = nums[i] - 1;
            if (s != i && nums[s] != nums[i]){
                int t = nums[i];                
                nums[i] = nums[s];
                nums[s] = t;
                --i;
            }
        }
        
        for (int j = 0; j < nums.Length; ++j){
            if (nums[j] != j+1)
                result.Add(j+1);
        }
        
        return result;
    }
}