class Solution {
public:
    int maximumUniqueSubarray(vector<int>& nums) {
        
        int maxval = 0;
        int sum = 0;
        int l = 0;

        unordered_map<int,int> map;
        for(int r = 0 ; r<nums.size();r++){
            if(map.find(nums[r]) == map.end()){
                map[nums[r]] = 1;
                sum = sum + nums[r]; 
            }else{
                while(map.find(nums[r]) != map.end() && l<r ){
                    sum = sum - nums[l];
                    map.erase(nums[l]);
                    l++;
                }

                map[nums[r]] = 1;
                sum = sum + nums[r];
            }

                maxval = max(maxval,sum);
        }

        return maxval;
    }
};