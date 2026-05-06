class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {

        vector<int> ans;
        vector<int> array;
        
         int n = nums.size();
         int a[n];
        for(int i=0;i<n;i++){
                a[i] = nums[i];
        }
        
      
        sort(nums.begin(),nums.end());
        
        int start = 0;
        int end = n-1;
 
        while(start<end){
            if(nums[start]+nums[end]==target){
                 array.push_back(nums[start]);
                array.push_back(nums[end]);
                break;
            }
            else if(nums[start]+nums[end]>target){
                end--;
            }
            else{
                    start++;
            }
        }
      
        for(int i=0 ;i<n;i++){
            for(int j=0;j<array.size();j++){
                if(a[i] == array[j]){
                   
                    ans.push_back(i);
                    break;

                }
            }
        }



        //  for(int i=0 ;i<n;i++){
        //     for(int j=0;j<n;j++){
        //             if(nums[i]+nums[j] == target){
        //                 ans.push_back(i);
        //                 ans.push_back(j);
        //                 break;
        //             }
        //     }
        // }



        return ans;
    }
};