class Solution {
public:
    double findMaxAverage(vector<int>& nums, int k) {
        int n = nums.size();
        int wsum = 0;
        for(int i = 0; i<k; i++){
            wsum = wsum + nums[i];
        }
        double avg = (double)wsum/k;
        for(int i = k; i<n;i++){
            wsum = wsum + nums[i];
            wsum = wsum - nums[i-k];
            double avgval =(double)wsum/k;
            avg = max(avg,avgval);
        }

        return avg;
    }
};