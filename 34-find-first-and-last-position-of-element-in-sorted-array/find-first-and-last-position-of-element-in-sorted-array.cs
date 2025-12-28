public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int [] arr = new int[2];
int first = firstocc(nums,target);
int last = lastocc(nums,target);

    arr[0] = first;
    arr[1] = last;
return arr;
    }


    int firstocc(int[] nums,int target){
        int s = 0;
        int e = nums.Length - 1;
        int first = -1;
        while(s<=e){
            int mid = s+(e-s) /2;
            if(nums[mid] == target){
               first = mid;
               e = mid - 1; 
            }else if(nums[mid] > target){
                    e = mid -1;
            }else if(nums[mid]<target){
                    s = mid + 1;
            }
        }
        return first;
    }


 int lastocc(int[] nums,int target){
        int s = 0;
        int e = nums.Length - 1;
        int last = -1;
        while(s<=e){
            int mid = s+(e-s) /2;
            if(nums[mid] == target){
               last = mid;
               s = mid + 1; 
            }else if(nums[mid] > target){
                    e = mid -1;
            }else if(nums[mid]<target){
                    s = mid + 1;
            }
        }

        return last;
    }

}