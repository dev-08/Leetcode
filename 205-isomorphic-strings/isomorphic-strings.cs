public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length) return false;
    Dictionary<char,char> stot = new Dictionary<char,char>();
 Dictionary<char,char> ttos = new Dictionary<char,char>();
        for(int i = 0 ;i<s.Length;i++){
            char a = s[i];
            char b = t[i];

            if(stot.ContainsKey(a)){
                if(stot[a] != b) return false;
            }else{
                stot.Add(a,b);
            }

            if(ttos.ContainsKey(b)){
                if(ttos[b]!=a) return false;
            }else{
                ttos.Add(b,a);
            }
        }
        return true;
    }
}