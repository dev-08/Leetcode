public class Solution {
        int sum = 0;
        int [] dp;
    public int MinCostClimbingStairs(int[] cost) {
         
            int n = cost.Length;
         dp = new int[n];
         Array.Fill(dp,-1);
        int ans = Math.Min(costof(cost,n-1),costof(cost,n-2));
        return ans;
    }


        public int costof(int[] cost,int n){
       
            if(n==0) { return  cost[0];}
            if(n==1) { return  cost[1]; }
                if (dp[n]!= -1 ) return dp[n];
                
                dp[n] =  cost[n] + Math.Min(costof(cost,n-1) , costof(cost,n-2));
                return dp[n];

        }

}