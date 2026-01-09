public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        
        int n = nums.Length;

        int [] temp = new int[n];
         IList<int> result = new List<int>();
        for(int i = 0 ; i<nums.Length;i++){
            int val = nums[i];
            temp[val-1] = -1;
        }

        for(int i=0;i<temp.Length;i++){
           if(temp[i] != -1){
            result.Add(i+1);
           }
        }
    return result;

    }
}