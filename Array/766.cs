// 152ms, 75%, 10m, 1t
public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        if(matrix == null)
            return true;
        
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        for(int i = 0; i < cols; ++i){
            int v = matrix[0,i];
            int x = 1, y = i+1;
            while(x < rows && y < cols){
                if (matrix[x++,y++] != v)
                    return false;                
            }              
        }
        
        for (int j = 1; j < rows; ++j){
            int v = matrix [j, 0];
            int x = j+1, y = 1;
            while(x < rows && y < cols){
                if (matrix[x++,y++] != v)
                    return false;                
            }
        }
        
        return true;
    }
}