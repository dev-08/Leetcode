public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
     int n = nums.Length;
     
    Dictionary<int,int> hashmap = new Dictionary<int,int>();
     for(int i = 0;i<n;i++){
            if(hashmap.ContainsKey(nums[i])){
                    return true;
            }else{
                hashmap.Add(nums[i],1);
            }
     }
     return false;
    
}
}