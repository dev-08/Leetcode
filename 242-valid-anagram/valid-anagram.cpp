class Solution {
public:
    bool isAnagram(string s, string t) {
        
        unordered_map<char,int> freq;

        if(s.length()!=t.length()) return false;
        for(int i = 0 ;i<s.length(); i ++){
            if(freq.find(s[i]) != freq.end() ){
                freq[s[i]]++;
            }else{
                freq[s[i]] = 1;
            }
        }


        for(int i = 0; i<t.length(); i++){
            if(freq.find(t[i]) == freq.end() || freq[t[i]] == 0 ){
                return false;
            }else{
                freq[t[i]] --;
            }

        }


        return true;
    }
};