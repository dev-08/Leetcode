class Solution {
public:
    int pivotIndex(vector<int>& nums) {

            int n = nums.size();
            int ans =0;
            for(int i = 1; i<n; i++){
                     nums[i] = nums[i] + nums[i-1];
                     cout<< nums[i] << endl ;
            }

            for(int i=0; i<n; i++){
                int left ;
                if(i==0) left=0;
                else left =  nums[i-1];
                int right = nums[n-1] - nums[i];
        
                if(left == right){
                   ans = i; 
                   return ans;
                   break;
                }
            }

     
        return -1;

    }
};