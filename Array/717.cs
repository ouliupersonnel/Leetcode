// 112ms, 48%, 35m, 15t
public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i = 0;
        while(i < bits.Length - 1){
            if (bits[i++] == 1)
                ++i;
        }
        return i == bits.Length - 1;
    }
    
}