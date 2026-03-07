class Solution {
public:
    int subarraysDivByK(vector<int>& nums, int k) {
        unordered_map<int,int> map;
        int rsum = 0;
        int ans = 0;
        map[0] = 1;
        for(int i = 0 ; i<nums.size();i++){
            rsum = rsum + nums[i];
              int modval = ((rsum % k) + k) % k;

            if(map.find(modval) != map.end()){
                    ans = ans+map[modval];
                    map[modval]++;
            }else{
                map[modval]= 1;
            }
        }

        return ans;
    }
};