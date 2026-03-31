class Solution {
public:
    int longestOnes(vector<int>& nums, int k) {
        int i = 0;
        int n = nums.size();
        int zc = 0;
        int first = 0;
        int maxval = 0;
        while(i<n){
            if(nums[i] == 0){
                    if(zc<k) {
                         zc++;
                    }else{
                        zc++;
                    
                        if(nums[first] == 0){
                            first++;
                        }else{
                            while(nums[first]!=0){
                                first++;
                            }
                            if(nums[first] == 0){
                                first++;
                            }
                        }
                        zc--;
                    }
                   

            }
             int val = i-first+1;
                   maxval = max(maxval,val);
            i++;
        }

        return maxval;
    }
};