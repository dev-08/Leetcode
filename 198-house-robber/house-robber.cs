public class Solution {
    public int Rob(int[] nums) {
        
        for(int i=1;i<nums.Length;i++){
            
            if(i>1){
                nums[i] = Math.Max(nums[i-1] , nums[i]+nums[i-2]);
            }else{
                nums[i]=Math.Max(nums[i],nums[i-1]);
            }
        }
        return nums[nums.Length-1];

    }
}






// public class Solution {
//     public int Rob(int[] nums) {
//             return helper(nums,0,0);

//     }


//     public int helper(int[] nums,int idx,int amount){

//         if(idx >= nums.Length){
//                 return amount;
//         }

//       return   Math.Max(helper(nums,idx+2,amount+nums[idx]),
//         helper(nums,idx+1,amount));


//     }
// }