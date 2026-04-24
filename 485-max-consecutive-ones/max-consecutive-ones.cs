public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int maxval = 0;
        for(int i = 0;i<nums.Length; i++){
            if(nums[i] == 1){
                    count++;
                maxval = Math.Max(maxval,count);
            }else{
                count = 0;
            }
        }

        return  maxval;
    }
}