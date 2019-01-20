// 316ms, 81.58%, 5m, 4t
public class Solution {
    public int[][] Transpose(int[][] A) {
        if (A == null || A.Length == 0 || A[0].Length == 0)
            return A;
        
        int[][] T = new int[A[0].Length][];
        for (int k = 0; k < T.Length; ++k)
            T[k] = new int[A.Length];
        
        for (int i = 0; i < A.Length; ++i)
            for (int j = 0; j < A[0].Length; ++j)
                T[j][i] = A[i][j];
        return T;
    }
}