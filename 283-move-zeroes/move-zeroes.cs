public class Solution {
    public void MoveZeroes(int[] nums) {
       int n = nums.Length;

       int e = n-1;
       while(e>=0){
        if(nums[e] == 0){
            for(int i = e ;i<n-1 ; i++){
                swap(nums,i,i+1);
            }
        }
        e--;
       }

    }

    public void swap(int[] nums , int i,int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}