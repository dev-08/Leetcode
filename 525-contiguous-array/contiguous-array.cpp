class Solution {
public:
    int findMaxLength(vector<int>& nums) {
        
        unordered_map<int,int>map;
        map[0] = -1;
        int maxval = 0;
        int rsum = 0;

        for(int i = 0; i<nums.size();i++){
            if(nums[i] == 1) rsum = rsum+1;
            if(nums[i] == 0) rsum = rsum-1;

            if(map.contains(rsum)){
                int diff = i - map[rsum];

                if(maxval<diff){
                    maxval = diff;
                }
            }

            if(map.find(rsum) == map.end()){
                map[rsum] = i;
            }


            
        }
            return maxval;
    }
    
};