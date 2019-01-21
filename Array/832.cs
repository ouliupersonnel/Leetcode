// 300ms, 82.39%, 6m, 6t
public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        for (int i = 0; i < A.Length; ++i){
            int l = 0, r = A[i].Length - 1;
            while(l < r){
                int t = 1 - A[i][l];
                A[i][l] = 1 - A[i][r];
                A[i][r] = t;
                ++l; --r;
            }
            if (l == r)
                A[i][l] = 1 - A[i][l];
        }
        return A;
    }
}
