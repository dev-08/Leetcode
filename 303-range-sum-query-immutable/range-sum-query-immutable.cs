public class NumArray {

    int [] prefixval;
    public NumArray(int[] nums) {
        int n = nums.Length;
        prefixval = new int[n];
        prefixval[0] = nums[0];
        for(int i = 1 ; i<n;i++){
            prefixval[i] = nums[i] + prefixval[i-1];
        }
    }
    
    public int SumRange(int left, int right) {
        if (left == 0) return prefixval[right];
        return prefixval[right] - prefixval[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */