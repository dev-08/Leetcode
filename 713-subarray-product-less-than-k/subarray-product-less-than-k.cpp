class Solution {
public:
    int numSubarrayProductLessThanK(vector<int>& nums, int k) {
     int n = nums.size();
     int l=0;
    
     int prod = 1;
     int count = 0;
     for(int r = 0;r<n;r++){
        prod = prod * nums[r];
        while(prod>=k && l <= r){
            prod = prod / nums[l];
            l++;
        }
        count = count+ ((r-l) +1);
     }

     return count;   
    }
};