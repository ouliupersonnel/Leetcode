// 148ms, 75.61%, 5m, 4t
public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        if(nums == null)
            return nums;
        int rows = nums.GetLength(0), cols = nums.GetLength(1);
        if (rows * cols != r * c)
            return nums;
        
        int[,] result = new int[r, c];
        int ii = 0, jj = 0;
        for(int i = 0; i < rows; ++i){
            for (int j = 0; j < cols; ++j){
                result[ii, jj] = nums[i, j];
                if(++jj == c){
                    jj = 0;
                    ++ii;
                }
            }
        }
        
        return result;
    }
}