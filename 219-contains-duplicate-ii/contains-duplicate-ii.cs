public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
       Dictionary<int,int> hmap = new Dictionary<int,int>();
       for(int i = 0;i<nums.Length;i++){
        if(hmap.ContainsKey(nums[i])){
            int diff = Math.Abs(i-hmap[nums[i]]);
            hmap[nums[i]] = i;
            if(diff<=k) return true;
        }else{
            hmap.Add(nums[i],i);
        }
       }

       return false;
    }
}