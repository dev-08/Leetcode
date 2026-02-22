public class Solution {
    public long MaximumSumScore(int[] nums) {
        long sum = 0;
        long left = 0;
        long right = 0;
        long ans = int.MinValue;
        for(int i = 0;i<nums.Length;i++){
            sum = sum + nums[i];
        }

        for(int i = 0 ;i<nums.Length;i++){
            left = left + nums[i];
            right = sum - left + nums[i];
            ans = Math.Max(ans,Math.Max(left,right));

        }
        return ans;
    }
}