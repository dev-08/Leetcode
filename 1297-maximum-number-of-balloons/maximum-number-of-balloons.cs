public class Solution {
    public int MaxNumberOfBalloons(string text) {
        string s = "balloon";
        Dictionary <char,int> map = new Dictionary<char,int>();
        for(int i= 0 ;i<text.Length ; i++){
            char c = text[i];
            if(map.ContainsKey(c)){ map[c]++; }
            else{ map.Add(c,1); }
        }
        int count = 0;
        int j = 0;
        while(j<s.Length){
            if(!map.ContainsKey(s[j]) || map[s[j]] == 0 )
            {
                return count;
            }
            else
            {
                map[s[j]]--;
                j++;
            }

            if(j==s.Length)
            {
                count++;
                j=0;
            }
        }
            return count;
    }
}