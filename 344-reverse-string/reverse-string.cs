public class Solution {
    public void ReverseString(char[] s) {
        
        int st = 0;
        int e = s.Length-1;
        
        while(st<e){
            char c = s[st];
            s[st] = s[e];
            s[e] = c;

            st++;
            e--;
        }

      
    }
}