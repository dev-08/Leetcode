public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
            int m = matrix.Length;
            int n = matrix[0].Length;
            int i = 0;
            int j = n-1;
            while(i<m && j>=0){
                if(matrix[i][j] == target)return true;
                 if(matrix[i][j] <target){
                    i++;
                }else{
                    j--;
                }
            }

            return false;
    }
}