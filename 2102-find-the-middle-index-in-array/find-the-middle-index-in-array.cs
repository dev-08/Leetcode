public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int n = nums.Length;
        for(int i = 1;i<n;i++){
            nums[i] += nums[i-1];
        }

        int left = 0;
        int right = n-1;
        int RightVal = 0 ;
    
        for(int i=0;i<n;i++){
            if(i == 0) {
                left = 0;}
            else {
                left = nums[i-1];
            }

            if(i == right){
                 RightVal = 0; }

            else { 
                RightVal = nums[right] - nums[i];
            }



            if(left==RightVal){return i;}
        }

        return -1;
    }
}