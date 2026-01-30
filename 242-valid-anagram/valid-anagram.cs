public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char,int> frequ = new Dictionary<char,int>();
        foreach(char c in s){
            if(frequ.ContainsKey(c)) {
                frequ[c]++;
            }else{
                frequ[c] = 1;
            }
        }

        foreach(char c in t){
            if(!frequ.ContainsKey(c) || frequ[c] == 0) { return false;}
            frequ[c]--;
        }

        return true;
    }
}