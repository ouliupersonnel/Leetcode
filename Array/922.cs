// 340ms, 62.32%, 5m, 1t
public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        if (A == null || A.Length == 0)
            return A;
        
        int o = 0, e = 1;
        while(o < A.Length && e < A.Length){
            if (A[o] % 2 == 0){
                o += 2;
                continue;
            }
            if (A[e] % 2 == 1){
                e += 2;
                continue;
            }
            
            int t = A[o];
            A[o] = A[e];
            A[e] = t;
            o+=2;
            e+=2;
        }
        
        return A;
    }
}