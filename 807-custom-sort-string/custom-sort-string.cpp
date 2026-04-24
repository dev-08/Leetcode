class Solution {
public:
    string customSortString(string order, string s) {
        unordered_map<char,int> map;


        for(int i = 0 ;i<s.length();i++){
        
            if(map.find(s[i])!=map.end()){
                map[s[i]]++;
            }else{
                map[s[i]] = 1;
            }
        }
        string result ="";
        for(int i =0; i<order.length();i++){

                if(map.find(order[i]) != map.end()){
                    while(map[order[i]] > 0){
                        map[order[i]]--;

                        result = result + order[i];  
                    }
                }

        }

        for(auto it : map){
            if(it.second >0){
                while(map[it.first] >0){
                result += it.first;
                map[it.first]--;
                }
            }
        }

        return result;

      
        
    }
};