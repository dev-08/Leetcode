public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
int n = s.Length;
    for(int i=0;i<n;i++){
        if(map.ContainsKey(s[i])){
            map[s[i]]++;
        }else{
            map.Add(s[i],1);
        }
    }

    for(int i=0;i<n;i++){
        if(map[s[i]] == 1) {return i;}
    }

        return -1;
    }
}