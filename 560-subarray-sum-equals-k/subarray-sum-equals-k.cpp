class Solution {
public:
    int subarraySum(vector<int>& nums, int k) {
        

        unordered_map<int,int> map;
        int count = 0;
        map[0] = 1;
        int rsum = 0;
        for(int i = 0;i<nums.size();i++){
            rsum = rsum +nums[i];
            int diff = rsum - k;
            if(map.find(diff)!=map.end()){
                count = count + map[diff];
            }

            if(map.find(rsum)!= map.end()){
                map[rsum]++;
            }else{
                map[rsum] = 1;
            }
        }

        return count;
    }
};