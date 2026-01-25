public class Solution {
    public int MinCost(int[][] costs) {
        
        int m = costs.Length;
        int n = costs[0].Length;

        for(int i = 1;i<m;i++){
            for(int j = 0;j<n;j++){
                if(j==0){
                costs[i][j] = Math.Min(costs[i][j] + costs[i-1][1],
                costs[i][j] + costs[i-1][2]);
                }else if(j==1){
                costs[i][j] = Math.Min(costs[i][j] + costs[i-1][0],
                costs[i][j] + costs[i-1][2]
                );
                }
                else if(j==2){
                costs[i][j] = Math.Min(costs[i][j] + costs[i-1][0],
                costs[i][j] + costs[i-1][1]
                );
                }
            }
        }

        return Math.Min(costs[m-1][0] , Math.Min(costs[m-1][1] , costs[m-1][2]));

    }
}