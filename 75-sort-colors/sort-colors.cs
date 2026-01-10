public class Solution {
    public void SortColors(int[] nums) {
        int n = nums.Length -1;
        int left = 0;
        int right = n;
        int mid = 0;
        while(mid<=right ){
            if(nums[mid] ==2){
                    swap(nums,mid,right);
            right--;
            }
            else if(nums[mid] == 0 ){
                    swap(nums,mid,left);
            left++; mid++;
            } else{
                mid++;
            }
        } 
        
     void swap(int[] nums , int i, int j){
        if(i==j) return;
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j]= temp;
     }
    }

  
}