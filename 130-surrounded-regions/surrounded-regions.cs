public class Solution {
    public void Solve(char[][] board) {
        
            int m = board.Length;
            int n = board[0].Length;

          int[][] dirs = new int[][]{
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
                };



        for(int i = 0;i<m;i++){
            for(int j = 0;j<n;j++){
                if(i==0 || j==0 || i == m-1 || j == n-1){
                    dfs(board,dirs,i,j,m,n);
                }
            }
        }

         for(int i = 0;i<m;i++){
            for(int j = 0;j<n;j++){
                if( board[i][j] == 'B'){
                  board[i][j] =  'O';
                }else if ( board[i][j] == 'O'){
                  board[i][j] =  'X';
                }
            }
        }
    }


    public void dfs(char [][] board,int [][] dirs,int i,int j ,int m,int n){
        if(board[i][j] !='O') return ;

        board[i][j] = 'B';
        foreach(int [] dir in dirs){
            int nr = i+dir[0];
            int nc = j+dir[1];

        if(nr>0  &&  nc>0  &&  nr<m  &&  nc<n  && board[nr][nc] == 'O'){
               dfs(board,dirs,nr,nc,m,n);
        }
    }

    }
}