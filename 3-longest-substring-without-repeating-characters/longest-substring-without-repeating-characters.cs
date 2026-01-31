public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> h = new HashSet<int>();
        int slow = 0;
        int max = 0;

        for(int i=0;i<s.Length;i++){
            char c = s[i];
            if(h.Contains(c)){
                while(s[slow] != c){
                    h.Remove(s[slow]);
                    slow++;
                }
                slow++;
            }else{
                h.Add(c);
            }
            max = Math.Max(max,i-slow +1);
        }

    return max;
    }
}