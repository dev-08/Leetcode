public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
       int m = mat.Length;        // number of rows
    int n = mat[0].Length;  
        
        int [] result = new int[m*n];
        int total = m*n;
        int count = 0;

        int i = 0;
        int j = 0;
        bool dir = true;
        while(total!=count){
            result[count] = mat[i][j];
            count++;
            if(dir){
                if(i==0 && j<n-1){
                    j++;
                    dir = !dir;
                }else if(j == n-1){
                    i++;
                    dir = !dir;
                }else{
                    i--;j++;
                }
            }
            else{
                if(j==0 && i<m-1){
                    i++;
                    dir = !dir;
                }else if(i == m-1){
                    j++;
                    dir = !dir;
                }else{
                    j--;i++;
                }
            }
        }
        return result;
    }
}