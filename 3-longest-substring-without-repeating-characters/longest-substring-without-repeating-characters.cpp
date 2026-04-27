class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int n = s.length();
        int i = 0;
        int maxval =0;
        unordered_map<char,int> map;
        for(int j = 0; j<n; j++) {
            if(map.find(s[j]) == map.end()){
                map[s[j]] = j;
            }else{
                while(i<j && map[s[j]]!=-1 && s[i]!=s[j]){
                    map[s[i]] = -1;
                    i++;
                }
                    if(map[s[j]]!=-1){
                        i++;
                    }
                map[s[j]] = j;
            }

            maxval =max(maxval,(j-i+1));        
        }

        return maxval;
    }
};