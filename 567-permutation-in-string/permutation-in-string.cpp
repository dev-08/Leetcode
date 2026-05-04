class Solution {
public:
    bool checkInclusion(string s1, string s2) {
        unordered_map<char,int> map;


        for(int i = 0; i<s1.size();i++){
            if(map.find(s1[i])!= map.end()){
                map[s1[i]]++;
            }else{
                map[s1[i]] = 1;
            }
        }

        int match = 0;
        int r = 0;
        while (r<s2.size()){

                if(map.find(s2[r])!=map.end()){
                    int cnt = map[s2[r]] -1 ;
                    map[s2[r]]--;
                    if(cnt == 0){
                        match++;
                    }
                }


                if(r>=s1.size()){

                    if(map.find(s2[r-s1.size()]) != map.end()){
                        int cnt = map[s2[r-s1.size()]] + 1;
                        map[s2[r-s1.size()]]++;
                        if(cnt == 1){
                            match--;
                        }
                    }
                }
                r++;

                if(match==map.size()){
                    return true;;
                }
        }

        return false;
    }
};