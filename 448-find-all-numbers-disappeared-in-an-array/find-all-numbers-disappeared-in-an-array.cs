public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        
        int n = nums.Length;

        int [] temp = new int[n];
         IList<int> result = new List<int>();
        for(int i = 0 ; i<nums.Length;i++){
            int val = Math.Abs(nums[i]);
            if(nums[val-1] > 0 ){
                nums[val-1] = nums[val-1]*(-1);
            }
        }

         for(int i = 0 ; i<nums.Length;i++){
            if(nums[i] >0){
                result.Add(i+1);
            }
        }

       
    return result;

    }
}