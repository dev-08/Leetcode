public class Solution {
    public int FindMaxLength(int[] nums) {
        int n = nums.Length ;
        Dictionary<int,int> map = new Dictionary<int,int>();

        map.Add(0,-1);
        int rsum = 0;
        int max = 0;
        for(int i = 0;i<n;i++){
            if(nums[i] == 1) {
                rsum = rsum+1;
            }else{
                rsum = rsum-1;
            }

            if(map.ContainsKey(rsum)){
                int diff = i - map[rsum];
                max = Math.Max(max,diff);
            }else{
                map.Add(rsum,i);
            }
        }

        return max;
    }
}