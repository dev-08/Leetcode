class Solution {
public:
    int lengthOfLongestSubstringTwoDistinct(string s) {
       int n = s.size();
       int l = 0;
       int maxval = 0; 
        unordered_map<char,int> map;

        for(int r = 0 ;r<n;r++){
            if(map.find(s[r])!=map.end()){
                map[s[r]]++;
            }else{
                map[s[r]] = 1;
            }
            while(map.size()>2){
                map[s[l]]--;
                if(map[s[l]] < 1){
                    map.erase(s[l]);
                }
                l++;
            }
            maxval = max(maxval,(r-l)+1);
        }

        return maxval;
    }
};