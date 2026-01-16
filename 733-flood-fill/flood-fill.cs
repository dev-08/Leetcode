public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
            int m = image.Length;
            int n = image[0].Length;
            int[][] dirs = new int[][]{
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
                }; 
            int start = image[sr][sc];
            dfs(image,dirs,sr,sc,m,n,color,start);

            return image;
    }

    public void dfs(int[][] image,int[][] dirs,int i,int j,int m , int n,int color,int start){
        if(image[i][j] != start) 
        { return; }
        if(image[i][j] == color)
        { return; }

        image[i][j] = color;
        foreach(int[] dir in dirs){
            int nr = i + dir[0];
            int nc = j + dir[1];

            if(nr>=0 && nc>=0 && nr<m && nc<n && image[nr][nc] == start){
                dfs(image,dirs,nr,nc,m,n,color,start);
            }
        }

    }
}