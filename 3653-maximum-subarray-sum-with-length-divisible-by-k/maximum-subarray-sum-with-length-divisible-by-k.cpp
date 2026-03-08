class Solution {
public:
    long long maxSubarraySum(vector<int>& nums, int k) {
        int n = nums.size();
        long long rsum = 0;
        long long maxval = LLONG_MIN;
    
        unordered_map<int,long long> map;
        map[0] = 0;
        for(int i = 1; i <= nums.size();i++){
            rsum = rsum + nums[i-1];
            int modval = i%k;
            if(map.find(modval)!=map.end()){
                    long long diff = rsum - map[modval];
                    maxval = max(maxval,diff);
                    map[modval] = min(map[modval],rsum);
            }else{
                map[modval] = rsum;
            }
        }

        return maxval;
    }
};