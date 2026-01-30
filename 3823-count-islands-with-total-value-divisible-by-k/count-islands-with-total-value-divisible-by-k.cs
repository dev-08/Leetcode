public class Solution {
    public int CountIslands(int[][] grid, int k) {
        int result = 0;
        long island_sum = 0;
        int n = grid.Length, m = grid[0].Length;

        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] != 0 ){
                    island_sum = DFS(grid, i , j);
                    if (island_sum % k == 0 ) result+=1;
                }
            }
        }
        return result;

    }

    public long DFS(int[][] grid, int x, int y){
        long tmp ;
        int n = grid.Length, m = grid[0].Length;
        
        if( 0 <= x && x < n && 0 <= y && y < m && grid[x][y] != 0){
            tmp = grid[x][y];
            grid[x][y] = 0;
            return tmp + DFS(grid, x+1, y) + DFS(grid, x, y+1) + DFS(grid, x-1, y) + DFS(grid, x, y-1) ;
        }

        return 0;
    }
}



// public class Solution {
//     public int CountIslands(int[][] grid, int k) {
//        int m = grid.Length;
//        int n = grid[0].Length;
//         int count = 0;
//           int [][] dirs = new int [][]{
//             new int[] {0,1},
//             new int[] {0,-1},
//             new int[] {1,0},
//             new int[] {-1,0}
//         };
//        for(int i = 0; i<m;i++){
//         for(int j=0; j<n ; j++){
//             if(grid[i][j] !=0){
//                 double val =dfs(grid,dirs,i,j,m,n); 
//                 if(val%k == 0 ){ count++;}
//             }
//         }
//        } 

//        return count;
//     }


//     public double dfs(int [][] grid, int [][] dirs,int i,int j,int m,int n){
//         if(grid[i][j] == 0) return 0;
//         double val = grid[i][j] ; 
//         grid[i][j] = 0;

//         foreach (int [] dir in dirs){
//             int nr = dir[0] + i;
//             int nc = dir[1] + j;
//             if(nr >= 0 && nc >= 0 && nr < m && nc < n && grid[nr][nc] != 0){
//                 val = val + dfs(grid,dirs,nr,nc,m,n);
//             }
//         }
//         return val;
//     }
// }