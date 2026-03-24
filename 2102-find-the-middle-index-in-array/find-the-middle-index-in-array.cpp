class Solution {
public:
    int findMiddleIndex(vector<int>& nums) {
        vector<int> prefix;
       int n = nums.size();
       prefix.push_back(nums[0]);
       for(int i = 1;i<n; i++){
            prefix.push_back( prefix[i-1] + nums[i]);
       }

        int left = 0;
        int right = 0;
       for(int i = 0 ; i<n;i++)
        {
            if(i==0){
                 left = 0;
            } else {
                left = prefix[i-1];
            }

            if(i==n-1){ 
                right = 0;
            } else {
                right = prefix[n-1] - prefix[i];
            }

            if(left == right)
            {
                    return i;
            }
        }

        return -1;



    }
};