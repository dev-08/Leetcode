public class Solution {
    public int FindMaxFish(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int [][] dirs = new int [][]{
            new int[] {0,1},
            new int[] {0,-1},
            new int[] {1,0},
            new int[] {-1,0}
        };
int max = 0;
        for(int i = 0;i<m ; i++){
            for(int j = 0; j<n;j++){
                if(grid[i][j] != 0){
                max = Math.Max(dfs(grid,dirs,i,j,m,n),max);    
                }
            }
        }
    return max;
    }

    public int dfs(int [][] grid, int [][] dirs , int i, int j ,int m,int n){
            if(grid[i][j] == 0) return 0;
            int val = grid[i][j];
            grid[i][j] = 0;
            foreach(int [] dir in dirs){
                int nr = dir[0] + i;
                int nc = dir[1] + j;
        
        if(nr >= 0 && nc >= 0 && nr < m && nc < n && grid[nr][nc] != 0){
         
                val = val +    dfs(grid,dirs,nr,nc,m,n);
                }
            }
            return val;
    }
}