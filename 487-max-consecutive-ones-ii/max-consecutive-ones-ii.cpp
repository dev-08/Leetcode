class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int n = nums.size();
        int l =0 ;
        int count = 0;
        int maxval = 0;
        for(int r = 0; r<n; r++){
            if(nums[r] == 0){
                count++;
            }

            while(count>1){
                if(nums[l] == 0){
                    count--;
                }
                l++;
            }
            int val = r-l+1;
            maxval = max(maxval,val);
        }

        return maxval;
    }
};