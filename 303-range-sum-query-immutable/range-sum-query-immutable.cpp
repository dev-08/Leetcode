class NumArray {
public:
    vector<int> result;
    NumArray(vector<int>& nums) {
        result.push_back(nums[0]);
        cout<< result[0];
        for(int i = 1; i<nums.size(); i++){
            result.push_back( nums[i] + result[i-1]);
            cout << result[i] << endl;
        }
    }
    
    int sumRange(int left, int right) {
        if (left==0) return result[right];

        return result[right] - result[left-1];
    }
};

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray* obj = new NumArray(nums);
 * int param_1 = obj->sumRange(left,right);
 */