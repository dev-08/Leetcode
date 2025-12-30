public class Solution {
    public int Search(int[] nums, int target) {

        int pivot = getpivot(nums);
        int a = -1;
       
          if(nums[pivot] <= target && target<= nums[nums.Length-1]){
            a = binarysearch(nums,target,pivot,nums.Length-1);
        }else{
            a = binarysearch(nums,target,0,pivot);
        }
        
return a;
    }
public int binarysearch(int[] arr,int target,int s,int e ){

        while(s<=e){
            int mid = s + (e-s) /2;

            if(arr[mid] == target){
                return mid;
            }
            else if(arr[mid]<target){
                s = mid + 1;
            }else if(arr[mid]> target){
                e = mid - 1;
            }
        }

        return -1;
}



    public int getpivot(int[] arr)
{

    int s = 0;
    int e = arr.Length-1;
    
    while(s<e){
        int mid = s+(e-s)/2;

        if(arr[mid]>= arr[0]){
            s = mid+1;
        } else{
            e = mid;
        }   
    }

    return e;
}}