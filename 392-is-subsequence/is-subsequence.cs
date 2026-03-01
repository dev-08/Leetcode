public class Solution {
    public bool IsSubsequence(string s, string t) {
        int a = 0;
        int b = 0;

        while(a<s.Length && b<t.Length){
            char sa = s[a];
            char tb = t[b];
            if(sa==tb){
                a++;
            }b++;
        }

        if(a==s.Length) {
            return true;
        }

        return false;
    }
}