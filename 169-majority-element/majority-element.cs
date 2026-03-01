public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }else{
                map.Add(nums[i],1);
            }
        }

        int max = 0;
        int ans = 0;
        foreach(var item in map){
            int val = item.Value;
            if(max <val )
            {
                max = val;
                ans = item.Key;
            }
        }

        return ans;

    }
}