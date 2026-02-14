public class Solution {
    public int PivotIndex(int[] nums) {
        int n = nums.Length;
        for(int i = 1 ;i<n;i++){
            nums[i] += nums[i-1]; 
        }
       int left = 0;
       int right = n-1;
        for(int i = 0 ; i<n;i++){
                if (i==0) left = 0;
                else left = nums[i-1];
                int RightTotal = nums[right] - nums[i];
                if(left == RightTotal) return i;
        }

        return -1;
    }

   
}