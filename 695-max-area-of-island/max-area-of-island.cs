public class Solution {
    int max = 0;
    int count = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
         int[][] dirs = new int[][]{
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
                }; 
        for(int i = 0;i<m;i++){
            for(int j = 0 ; j<n;j++){
                count = 0;
                    dfs(grid,dirs,i,j,m,n);
            max = Math.Max(count,max);
            }
        }
        return max;
    }


    public void dfs(int [][] grid,int[][] dirs,int i,int j,int m,int n){
            if(grid[i][j] == 0){
                return;
            }
            grid[i][j] = 2;
            count++;
            foreach(int [] dir in dirs){
                int nr = dir[0] + i;
                int nc = dir[1] + j;
              
                if (nr >= 0 && nc >= 0 && nr < m && nc < n  && grid[nr][nc] == 1) {
                        dfs(grid,dirs,nr,nc,m,n);
                } 
            }

            
    }
}