class Solution {
public:
    int maxSubArrayLen(vector<int>& nums, int k) {
        unordered_map<int,int> map;
        int maxval =0;
        long long rsum = 0;
        map[0] = -1;
        for(int i =0;i<nums.size();i++){
            rsum = rsum + nums[i];
            long long  diff = rsum - k;
            if(map.find(diff) != map.end()){
                int val = i - map[diff];
                maxval = max(maxval,val);
            }

            if(map.find(rsum) == map.end()){
                  map[rsum] = i;
                    }

            
        }

        return maxval;
    }
};