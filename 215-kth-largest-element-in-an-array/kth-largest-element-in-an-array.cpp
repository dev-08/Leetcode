class Solution {
public:
    int findKthLargest(vector<int>& nums, int k) {
        int n = nums.size();
    priority_queue<int ,vector<int> , greater<int>> minhead;

        for(int i = 0; i<k;i++){
            minhead.push(nums[i]);
        }
                    
        for(int i = k; i<n ; i++){
            if(nums[i] > minhead.top()){
                minhead.pop();
                minhead.push(nums[i]);
            }
        }
        return minhead.top();
    }
};