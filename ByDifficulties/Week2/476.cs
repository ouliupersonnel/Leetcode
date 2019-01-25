// 48ms, 32.97%, 5m, 1t
public class Solution {
    public int FindComplement(int num) {
        if (num < 0)
            return ~num;
        else {
            int i = ~0;
            int k = num;
            while(num > 0){
                num >>= 1; i <<= 1;
            }
            return (~k & ~i);
        }
    }
}
