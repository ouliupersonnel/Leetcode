// 352ms, 100%, 38m, 3t
public class Solution {
    public int[] SortedSquares(int[] A) {
        if (A == null || A.Length == 0)
                return A;
            
        int l = 0, r = A.Length - 1;
        int[] B = new int[A.Length];
        int i = A.Length - 1;
        
        while (r > l)
        {                
            int ll = A[l] * A[l], rr = A[r] * A[r];
            
            if (!(ll > rr))
            {
                B[i--] = rr;
                --r;
            }

            if (!(ll < rr))
            {
                B[i--] = ll;
                ++l;
            }
        }

        B[0] = A[r] * A[r];           
        return B;
    }
}
