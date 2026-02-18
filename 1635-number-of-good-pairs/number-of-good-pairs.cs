public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int count = 0;
        for(int i = 0;i<nums.Length;i++){

int num = nums[i];

           count += map.GetValueOrDefault(num, 0);
map[num] = map.GetValueOrDefault(num, 0) + 1; 
        }
        return count;      
    }

}