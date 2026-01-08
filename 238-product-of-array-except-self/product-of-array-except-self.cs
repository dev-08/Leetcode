public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
              int rp = 1;
            int [] left = new int[nums.Length];

            int [] right = new int[nums.Length];
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
            for(int j=nums.Length-1;j>=0 ; j--){
                if(j==nums.Length-1) 
                { right[j] = rp;}
                else {
                    rp = rp*nums[j+1]; 
                    right[j] = rp; }
            }

        for(int k= 0 ; k<nums.Length; k++){
            nums[k] = left[k]*right[k];
        }

        return nums;
    }
}