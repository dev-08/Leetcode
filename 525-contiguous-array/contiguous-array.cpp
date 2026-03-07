class Solution {
public:
    int findMaxLength(vector<int>& nums) {
        
        unordered_map<int,int> map ;
        map[0] = -1;
            int rsum = 0;
            int maxval = 0;
        for(int i = 0 ;i<nums.size();i++){
            if(nums[i] == 1){
                    rsum = rsum +1;
            }else{
                rsum = rsum-1;
            }

       if (map.find(rsum) != map.end()) { // Key exists
    int diff = i - map[rsum];
    maxval = max(maxval, diff);
} else { // Key does not exist, store its first occurrence
    map[rsum] = i;
}
            
        }

        return maxval;
    }
};