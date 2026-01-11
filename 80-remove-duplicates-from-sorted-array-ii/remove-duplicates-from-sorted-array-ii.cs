public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int s = 0;
        int n = nums.Length;
        int count = 1;
       
        for(int i=1;i<n;i++){
                if(nums[i] == nums[i-1]) count++;
                else count = 1;
                if(count<=2) 
                {s++;
                nums[s] = nums[i];
                }
        }

        s++;
        return s;
    }
}