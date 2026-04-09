class Solution {
public:
    int totalFruit(vector<int>& fruits) {
            int n = fruits.size();
            int s = 0;
            int maz = INT_MIN;

            unordered_map<int,int> map;

            for(int i = 0; i<n;i++){
                if(map.find(fruits[i])!=map.end() ){
                    map[fruits[i]]++;
                }else if(map.size()<2){
                    map[fruits[i]] = 1;
                }else{
                    while(map.size()>=2){
                        map[fruits[s]]--;
                        if(map[fruits[s]] <= 0){
                            map.erase(fruits[s]);
                        }
                        s++;
                    }
                    map[fruits[i]] = 1;
                }
                maz = max(maz, (i-s)+1);
            }

        return maz;
    }
};