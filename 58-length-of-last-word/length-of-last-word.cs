public class Solution {
    public int LengthOfLastWord(string s) {
        
        string[] splits = s.Split(" ");
        int k = 0;
        foreach(string l in splits){
            if(!string.IsNullOrEmpty(l)){
k = l.Length;
            }
        }
        return k;
    }
}