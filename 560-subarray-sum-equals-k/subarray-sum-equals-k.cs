public class Solution {
    public int SubarraySum(int[] nums, int k) {
     int n = nums.Length;
     Dictionary<int,int> map = new Dictionary<int,int>();
        int rsum = 0;
        map.Add(0,1);
        int count = 0;
     for(int i = 0;i<n;i++){
            rsum = rsum + nums[i];
            int diff = rsum - k;

            if(map.ContainsKey(diff)){
                count = count + map[diff];  
            }

            if(!map.ContainsKey(rsum)){
                map.Add(rsum , 1);
            }else{
                map[rsum]++;
            }
     }

    
     return count;
    }
}