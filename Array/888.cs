// 408ms, 56%, 10m, 3t
public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        int sa = 0, sb = 0;
        for (int i = 0; i < A.Length; ++i)
            sa += A[i];
        for (int j = 0; j <B.Length; ++j)
            sb += B[j];
        
        int[] X, Y;
        int gap = 0;
        bool swapped = false;
        if (sa > sb){
            X = B; Y = A;
            gap = (sa - sb)/2;
            swapped = true;
        }
        else {
            X = A; Y = B;
            gap = (sb - sa)/2;            
        }
        
        int l = 0, r = 0; 
        int[] result = new int[2];
        Array.Sort(X); Array.Sort(Y);
        while(l < X.Length && r < Y.Length){
            if (Y[r] - X[l] > gap)
                ++l;
            else if (Y[r] - X[l] < gap)
                ++r;
            else{
                if (swapped){
                    return new int[2]{Y[r], X[l]};
                }
                return new int[2]{X[l], Y[r]};
            }                
        }
        
        return null;
    }
}