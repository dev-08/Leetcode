public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int s = 0;
        int f = 1;


        int [] ans = new int[2];
        while(s<=nums.Length-2){
            if(nums[s] + nums[f] == target)
            {
                ans[0] = s;
                ans[1] = f;
            }
            if(f== nums.Length-1){
                s++;
                f = s+1;
            }
            else{
            f++;
            }
        }

        return ans;
    }
}