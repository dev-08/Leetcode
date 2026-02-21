public class Solution {
    public int FindMiddleIndex(int[] nums) {
        for (int i = 1 ; i<nums.Length ; i++){
            nums[i] +=  nums[i-1];
        }

        int left = 0;
        int right  =0 ;
        for(int i = 0;i<nums.Length;i++){
            if(i==0){
                left = 0;
            }else{
 left = nums[i-1];

            } 
            
            
               
                right = nums[nums.Length-1] - nums[i];
            

            if(left == right){
                return i;
            }


        }

        return -1;
    }
}