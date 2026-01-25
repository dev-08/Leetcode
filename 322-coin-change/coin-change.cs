public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int [] result = new int[amount+1];

       Array.Fill(result, 999999); 
        result[0] = 0;
        int idx = 0;
        while(idx < coins.Length){

        for(int j = 1 ; j<result.Length; j++){
            if(coins[idx] <= j){
                result[j] = Math.Min(result[j] , 1+result[j-coins[idx]]);
            }
        }

        idx++;
        }
            if(result[amount] >= 999999) return -1;
        return result[amount];
    }
}



// public class Solution {
//     public int CoinChange(int[] coins, int amount) {
// int[,] dp = new int[coins.Length + 1, amount + 1];
//         dp[0,0] = 0;
//         for(int j=1 ; j<=amount ; j++){
//             dp[0,j] = 99999;
//         }

//         for(int i=1;i<=coins.Length;i++){
//             for(int j=1;j<=amount; j++){
//                 if(coins[i-1] > j){
//                     dp[i,j] = dp[i-1,j];
//                 }
//                 else{
//                     dp[i,j] = Math.Min(dp[i-1,j] , 1+dp[i,j-coins[i-1]]);
//                 }
//             }
//         }

//         if(dp[coins.Length,amount] >= 99999) return -1;
//         return dp[coins.Length,amount];


//     }
// }