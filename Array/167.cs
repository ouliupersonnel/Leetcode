// 288ms, 74.80%, 5m, 2t
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;
        while (l < r - 1){
            int x = numbers[l] + numbers[r];
            if (x == target)
                break;
            if (x < target)
                ++l;
            else
                --r;
        }
        
        return new int[]{l+1, r+1};
    }
}