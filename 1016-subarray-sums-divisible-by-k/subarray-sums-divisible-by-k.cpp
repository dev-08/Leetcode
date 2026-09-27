class Solution {
public:
    int subarraysDivByK(vector<int>& nums, int k) {
        
        int n = nums.size();
        int rsum = 0;
        int ans = 0;
        unordered_map<int,int> map;
        map[0] = 1;
        for(int i = 0; i<n; i++){
            
            rsum = rsum + nums[i];

            int modval = ((rsum % k) + k )%k ;
            int absmod = abs(modval);
            if(map.find(modval)!= map.end()){
                ans = ans + map[modval];
                map[modval]++;
            }else {
                map[modval] = 1;
            }

        }

        return ans;
    }
};