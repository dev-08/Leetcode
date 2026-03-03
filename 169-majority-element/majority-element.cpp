class Solution {
public:
    int majorityElement(vector<int>& nums) {
            unordered_map<int,int> map ;

            for(int i = 0;i<nums.size();i++){
                    if(map.find(nums[i])!=map.end()){
                        map[nums[i]]++;
                    }else{
                        map[nums[i]] = 1;
                    }
            }
            int maxval = 0;
            int ans = 0;
            for(auto &it : map){
                if(maxval < it.second){
                    maxval = it.second;
                    ans = it.first;
                }
            }

            return ans;

    }
};