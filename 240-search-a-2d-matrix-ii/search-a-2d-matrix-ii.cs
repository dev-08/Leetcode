public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int m = matrix.Length;
        bool a = false;
        for(int i=0;i<m;i++)
        {
             a = binarysearch(matrix[i],target);
            if(a==true){
            break;
            }
        }
        return a;
    }

    public bool binarysearch(int[] arr, int target){
            int s = 0;
            int e = arr.Length-1;
            while(s<=e){
                int mid = s+(e-s) /2;

                if(arr[mid] == target){
                    return true;
                }
                else if(arr[mid]<target){
                    s = mid+1;
                }else{
                    e = mid-1;
                }
            }

            return false;
    }
}