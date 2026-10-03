class Solution {
public:
    vector<vector<int>> threeSum(vector<int>& nums) {
        vector<vector<int>> ans;

        int n = nums.size();


        sort(nums.begin(),nums.end());
        for(int i = 0; i<n-2; i++){
            int l = i+1;
            int r = n-1;

            if(i>0 && nums[i] == nums[i-1]){
                continue;
            }
            if(nums[i] > 0){
                    break;
            }   
            while(l<r){
                int sum = nums[i] + nums[l] + nums[r];
                if(sum == 0){
                    vector<int> li = {nums[i], nums[l] , nums[r]};
                    ans.push_back(li);
                    l++;
                    r--;

                    while(l<n && l>i && nums[l] == nums[l-1]) l++;
                    while(r<n && r>i && nums[r] == nums[r+1] ) r--;
                }

                if(sum>0){
                    r--;
                }else if(sum<0){
                    l++;
                }


            }

        }


        return ans;
    }
};