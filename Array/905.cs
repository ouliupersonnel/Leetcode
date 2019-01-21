// 312ms, 51.57%, 5m, 1t
public class Solution {
    public int[] SortArrayByParity(int[] A) {
        if (A == null || A.Length == 0)
            return A;
        
        int l = 0, r = A.Length - 1;
        while(l < r){
            if (A[l] % 2 == 0){
                ++l;
                continue;
            }
            
            int t = A[l];
            A[l] = A[r];
            A[r] = t;
            --r;
        }
        
        return A;
    }
}
