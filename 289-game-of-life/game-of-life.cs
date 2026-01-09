public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        
int[][] dirs = new int[][]
{
    new int[] { 0, 1 },
    new int[] { 0, -1 },
    new int[] { 1, 0 },
    new int[] { -1, 0 },
    new int[] { -1, -1 },
    new int[] { -1, 1 },
    new int[] { 1, -1 },
    new int[] { 1, 1 }
};


                for(int i=0;i<m;i++){
                    for(int j=0;j<n;j++){
                        int countalive = CountAlive(board,dirs,i,j,m,n);
                        if(board[i][j] ==1 || board[i][j] == 2) {
                            
                            if(countalive <2 || countalive >3) { 
                                board[i][j] = 2;
                            }
                        }else{
                            if(countalive == 3){
                                board[i][j] = 3;
                            }
                        }
                    }
                }

         for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(board[i][j] == 2) { board[i][j] = 0;}
                if(board[i][j] == 3){board[i][j] = 1;}
            }
         }


    }


    public int CountAlive(int [][] board, int [][] dirs,int i,int j,int m,int n){
            int count = 0;
            foreach(int[] dir in dirs){
                int nr = i+dir[0];
                int nc = j+dir[1];

                if(nr>=0 && nc>=0 && nr<m && nc<n && (board[nr][nc] == 1 || board[nr][nc] == 2)){
                        count++;
                    }
            }
             return count; 
    }

                      
            
    }

