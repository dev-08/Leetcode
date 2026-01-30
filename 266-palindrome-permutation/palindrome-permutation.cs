public class Solution {
    public bool CanPermutePalindrome(string s) {
        if(s.Length == 1) return true;
        Dictionary<char ,int> freq = new Dictionary<char,int>();
        foreach(char c in s){
            if(freq.ContainsKey(c)) { freq[c]++; } 
            else {freq[c] = 1;}
        }
        int count = 1;
        foreach(var k in freq){
            if(k.Value %2 != 0 && count == 0  ) {return false;}
            if(k.Value%2!= 0 && count==1) {count--;}  
        }
        return true;
    }
}