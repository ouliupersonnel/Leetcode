// 144ms, 31.43%, 5m, 4t
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dnums = new HashSet<int>(nums);
        return nums.Length != dnums.Count;
    }
}