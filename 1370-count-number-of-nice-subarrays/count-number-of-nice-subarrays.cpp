class Solution {
public:
    int numberOfSubarrays(vector<int>& nums, int k) {
      int n = nums.size();

      unordered_map<string,int> map;
        int first = 0;
        int count  = 0;
  
        int l = 0;
        for(int r = 0; r<n;r++){
           if (nums[r] % 2 != 0) {
                if (map.find("ODD") == map.end()) {
                         first = r;
                         }
                      map["ODD"]++;
            }

            if (map.find("ODD") != map.end() && map["ODD"] == k) {
                int subs = (r - l + 1) - (r - first);
                count += subs;
            }


            if( map.find("ODD") != map.end() && map["ODD"] > k){
                first++;
                while(first<n && nums[first]%2==0) { first++;}

                while(map["ODD"]>k){
                    if(nums[l]%2!=0){
                        map["ODD"]--;
                    }
                    l++;
                }

            if(map["ODD"] == k){
                int subs = (r-l+1) - (r-first);
                count = count + subs;
            }

            }
        }


        return count;

    }
};