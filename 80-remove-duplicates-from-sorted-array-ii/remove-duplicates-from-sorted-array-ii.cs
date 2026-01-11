public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int s = 0;
        int f = s+1;
        int n = nums.Length;
        int count = 1;
        while(f<n){
            if(nums[f] == nums[f-1]){
                count++;
            }else{
                count = 1;
            }

            if(count<=2){
                s++;
                nums[s] = nums[f];
            }
            f++;
        }
        s++;
        return s;
    }
}