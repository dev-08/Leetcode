public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length ;
        int s = 0;
        int e = n - 1;
        int [] newnums = new int[n];
        int index = e;
        while(index>=0){
            int start = nums[s]*nums[s];
            int end = nums[e]*nums[e];

            if(end>start){
                newnums[index] = end;
                e--;
            }else{
                newnums[index] = start;
                s++;
            }
            index--; 
        }

        return newnums;
    }
}