class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        int n = nums.size();
        int i = 0;
        int j = i+1;

        while(j<n){
            if(nums[i] == 0 && nums[j]!=0){
                swap(nums, i, j);
            }
            
            if(nums[i]!=0){
                i++;
            }
            j++;
        }



    }


    void swap(vector<int>& nums, int i, int j){
        int c = nums[i];
        nums[i] = nums[j];
        nums[j] = c;
    }
};