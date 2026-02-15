// public class Solution {
//     public int[] LeftRightDifference(int[] nums) {
//         int n = nums.Length;
//         int [] ans  = new int[n];
//         for(int i =1;i<n;i++){
//             nums[i] += nums[i-1] ;
//         }
//         int left = 0;
//         int right = 0;
//         for(int i=0;i<n;i++){
//             if(i==0){
//                 left = 0;
//             }else{
//                 left = nums[i-1];
//             }

//             if(i==n-1){
//                 right = 0;
//             }else{
//                 right = nums[n-1]-nums[i];
//             }


//     ans[i] = Math.Abs(left-right);

//         }

//         return ans;
//     }
// }


public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length;
        int[] leftSum = new int[n];
        leftSum = LeftSum(nums);
        int[] rightSum = new int[n];
        rightSum = RightSum(nums);
        int[] ans = new int[n];
        for(int i = 0; i < n; i++)
        {
            ans[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }
        return ans;
    }

    public int[] LeftSum(int[] nums)
    {
        int[] pre = new int[nums.Length];
        for(int i = 0; i < nums.Length - 1; i++)
        {
            pre[i + 1] = pre[i] + nums[i];
        }
        return pre;
    }

    public int[] RightSum(int[] nums)
    {
        int[] pre = new int[nums.Length];
        for(int i = pre.Length - 1; i >= 1; i--)
        {
            pre[i - 1] = pre[i] + nums[i];
        }
        return pre;
    }
}