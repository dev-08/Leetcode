class Solution {
public:
    vector<int> findAnagrams(string s, string p) {
        
        unordered_map<char,int> map;
        for(int i = 0; i<p.size(); i++ ){
                if(map.find(p[i])!= map.end()){
                    map[p[i]]++;
                }else{
                    map[p[i]] = 1;
                }
        }

        vector<int> ans;
        int match = 0;

        int l = 0;
        int r = 0;
        while(r<s.size()){
                if(map.find(s[r])!=map.end()){
                    int cnt = map[s[r]] -1;
                        map[s[r]]-- ;
                        if(cnt == 0){
                            match++;
                        }
                }
                if(r>=p.size()){
                    if(map.find(s[r-p.size()])!= map.end()){
                            int cnt = map[s[r-p.size()]] + 1;
                            map[s[r-p.size()]]++ ;
                            if(cnt == 1){
                                match--;
                            }
                    }
                }
                r++;
                if(match == map.size()){
                    ans.push_back(r-p.size());
                }
        }

return ans;
    }
};