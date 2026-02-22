public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,-1);
        int maxval = 0;
    
        for(int i = 0 ;i<nums.Length ; i++){
            if(nums[i] == 1){
                if(i>0){
                nums[i] = nums[i-1] + 1;
                }
                else {
                    nums[i] = 1;
                }
            }else{
                if(i>0){
                nums[i] =  nums[i-1] - 1;
                }else{
                    nums[i] = -1;
                }
            }


            if(map.ContainsKey(nums[i])){
              maxval = Math.Max(maxval,  i - map[nums[i]]) ;
            }else{
                map.Add(nums[i],i);
            }
        }

return maxval;
    }
}