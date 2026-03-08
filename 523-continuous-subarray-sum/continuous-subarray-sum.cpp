class Solution {
public:
    bool checkSubarraySum(vector<int>& nums, int k) {
            int n = nums.size();
            int rsum = 0;
            unordered_map<int,int> map ;
            map[0] = -1;
            for(int i = 0;i<n ; i++){
                rsum = rsum + nums[i];
                int modval = rsum%k;
                    if(map.find(modval)!=map.end()){
                        int diff = i-map[modval];
                        if(diff>1){
                            return true;
                        }
                    }
                    else{
                        map[modval] = i;
                    }
            }
            return false;
    }
};