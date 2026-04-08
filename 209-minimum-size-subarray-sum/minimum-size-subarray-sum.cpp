class Solution {
public:
    int minSubArrayLen(int target, vector<int>& nums) {
        int f = 0;
        int s = 0;
        int n = nums.size();
        int rsum = 0;
        int minval = INT_MAX;

        for(int f = 0 ;f<n;f++){
                rsum = rsum + nums[f];

                while(rsum >=target){
                     minval = min(minval,(f-s) + 1);
                    rsum = rsum - nums[s];
                    s++;
                }
        }

        if(minval == INT_MAX)
            return 0;

        return minval;
    }
};