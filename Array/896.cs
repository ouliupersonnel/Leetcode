// 204ms, 95.12%, 10m, 2t
public class Solution {
    public bool IsMonotonic(int[] A) {
        bool increasing = true;
        if (A[0] > A[A.Length - 1])
            increasing = false;
        if (increasing){
            for (int i = 0; i < A.Length-1; ++i){
                if (A[i] > A[i+1])
                    return false;
            }
        }
        else{
            for (int i = 0; i < A.Length-1; ++i){
                if (A[i] < A[i+1])
                    return false;
            }
        }
         
        return true;
    }
}