class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        
        int r = 0;
        int l = 0;

        unordered_map<int,int> map;
            int maxval = 0;
        for(int r = 0; r<s.size();r++){
            if(map.find(s[r]) == map.end()){
                map[s[r]] = 1;
            }else{
                while(map.find(s[r]) !=map.end() && l<r){
                    map.erase(s[l]);
                    l++;
                }
                map[s[r]] = 1;
            }
            maxval = max(maxval,(r-l+1));
        }

        return maxval;
    }
};