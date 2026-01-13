public class Solution {
    public int OrangesRotting(int[][] grid) {
            
            if(grid == null) return 0;
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] dirs = new int[][]{
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
                };


            Queue<int[]> q = new Queue<int[]>();
            int fresh = 0;
            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    if(grid[i][j] == 2) 
                        {q.Enqueue(new int[] {i,j});
                     
                        }
                        else if(grid[i][j] == 1){ fresh++;}

                }
            }
            
            if(fresh==0) return 0;
            int time = 0;
            while(q.Any()){
                int size = q.Count;
                for(int i = 0;i<size;i++){
                    int [] curr = q.Dequeue();
                    foreach(int [] dir in dirs){
                        int nr = curr[0] + dir[0];
                        int nc = curr[1] + dir[1];
                        if(nr>=0 && nc>=0 && nr<m && nc<n && grid[nr][nc] == 1){
                              q.Enqueue(new int[] {nr,nc});
                            grid[nr][nc] = 2;
                          
                            fresh--;
                        }

                    }
                }

                time++;
            }

            if (fresh == 0) return time-1;

            return -1;
    }
}