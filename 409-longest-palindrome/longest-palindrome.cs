public class Solution {
    public int LongestPalindrome(string s) {
       Dictionary<char,int> map = new Dictionary<char , int>();
       for(int i = 0 ;i<s.Length ; i++){
        if(!map.ContainsKey(s[i])) { map.Add(s[i], 1); }
        else{ map[s[i]]++; }
       } 
        int count = 0;
        bool flag = false;
       foreach(var item in map){
            if(item.Value%2==0){
                count += item.Value;
            }else{
                flag = true;
                count += item.Value-1;
            }
       }
        if(flag) { return count + 1 ;}
       return count;
    }
}