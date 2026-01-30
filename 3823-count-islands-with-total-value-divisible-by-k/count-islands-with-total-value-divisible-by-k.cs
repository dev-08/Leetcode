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