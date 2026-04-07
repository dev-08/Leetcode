class Solution {
public:
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        
            deque<int> dq;
            int n = nums.size();
            vector<int> ans;
            for(int i= 0 ;i<n; i ++){

                while(!dq.empty() && nums[dq.back()] < nums[i]){
                    dq.pop_back();
                }
                dq.push_back(i);

                if(i>=(k-1)){
                    while(!dq.empty() && dq.front()< ((i-k) + 1)){
                        dq.pop_front();
                    }
                     ans.push_back(nums[dq.front()]);
                }
            }
    return ans;
    }
};




// ------------------------ Priority_queue -------------------didn't worke out 

// class Solution {
// public:
//     vector<int> maxSlidingWindow(vector<int>& nums, int k) {
//         int maxval = INT_MIN;
//         int n = nums.size();
//         int s = 0;
//         priority_queue<int> pq;
//         vector<int> ans;
//         for(int i = 0; i<k ; i++){
//             pq.push(nums[i]);
//         }
//         ans.push_back(pq.top());

//         for(int i = k;i<n;i++){
//                     priority_queue<int> temp;
//                     bool flag = false;
//             while(!pq.empty()){
//                     int val = pq.top();
//                     pq.pop();

//                     if(val == nums[s] && !flag){
//                         flag = true;
//                         continue;
//                     }
//                     temp.push(val);
//             }
//             s++;
//             pq = temp;
//             pq.push(nums[i]);
//             ans.push_back(pq.top());
//         }

//         return ans;

//     }
// };