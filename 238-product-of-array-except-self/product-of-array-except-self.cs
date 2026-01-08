public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
              int rp = 1;
            int [] left = new int[nums.Length];
            for(int i =0; i<nums.Length;i++){
                    if(i==0){
                        left[i] = rp;
                    } 
                        else{
                            rp = rp*nums[i-1];
                            left[i] = rp;
                        }
            }

            rp = 1;
            for(int i = nums.Length-2;i>=0;i--){
                rp = rp*nums[i+1];
                left[i] = left[i]*rp;
            }

        return left;
    }
}