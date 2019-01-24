// 172ms, 49.41%, 8m, 5t
public class Solution {
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int, int> startPos = new Dictionary<int, int>();
        Dictionary<int, int> endPos = new Dictionary<int, int>();
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; ++i){
            if (freq.ContainsKey(nums[i])){
                freq[nums[i]] = freq[nums[i]] + 1;
                endPos[nums[i]] = i;
            }
            else{
                startPos[nums[i]] = i;
                endPos[nums[i]] = i;
                freq[nums[i]] = 1;
            }
        }
        
        int maxf = 0, minl = 1000 * 1000;
        foreach(var kv in freq){
            if (kv.Value > maxf){
                maxf = kv.Value;
                minl = endPos[kv.Key] - startPos[kv.Key] + 1;                
            }
            else if (kv.Value == maxf){
                int l = endPos[kv.Key] - startPos[kv.Key] + 1;
                if (minl >= l)
                    minl = l;
            }
        }
        
        return minl;
    }
}