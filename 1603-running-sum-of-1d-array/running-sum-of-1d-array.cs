public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int [] ans = new int[nums.Length];
        int sum = 0;
        for(int i=0;i<nums.Length;i++){
            sum = sum + nums[i];
            ans[i] = sum ; 
        }

        return ans;
    }
}