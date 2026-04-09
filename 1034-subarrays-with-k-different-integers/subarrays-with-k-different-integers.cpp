class Solution {
public:
    int subarraysWithKDistinct(vector<int>& nums, int k) {
       return  atMost(nums,  k) - atMost(nums, k-1);
    }




    int atMost(vector<int>& nums, int k){
        int n = nums.size();
        int s = 0;
        int count = 0;
        if(k==0) return 0;
        unordered_map<int,int> map;

        for(int i =0; i<n; i++){
            if(map.find(nums[i]) != map.end()){
                    map[nums[i]]++;
            }else if(map.size()<k){
                map[nums[i]] = 1;
            }else{
                while(map.size()!= 0 && map.size()>=k){
                    map[nums[s]]--;
                    if(map[nums[s]] == 0){
                        map.erase(nums[s]);
                    }
                    s++;
                }
                
                    map[nums[i]] = 1;
            }

            count = count+(i-s) +1;
        }
        return count;
    }   
};