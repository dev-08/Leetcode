public class Solution {
    public long MaximumSumScore(int[] nums) {
        long [] prefixval = new long[nums.Length];
        int n = prefixval.Length;
            prefixval[0] = nums[0];
        for(int i =1 ;i<nums.Length;i++){
            prefixval[i] = nums[i] + prefixval[i-1];
        }   

    long Maxval = int.MinValue;
    long left = int.MinValue;
    long right = int.MinValue;
        for(int i = 0;i<n; i++){
                long max = int.MinValue;
                left = prefixval[i];
                if(i==0){
                    right = prefixval[n-1];
                }
                else{
                    right = prefixval[n-1] - prefixval[i-1];
                }

                max = Math.Max(right,left);
                Maxval = Math.Max(max,Maxval);
        }

        return Maxval;
    }
}