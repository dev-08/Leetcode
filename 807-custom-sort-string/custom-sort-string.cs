public class Solution {
    public string CustomSortString(string order, string s) {
        Dictionary <char , int> freq = new Dictionary<char , int>();

        foreach(char c in s){
            if(freq.ContainsKey(c)){ freq[c]++;}else{freq[c] = 1; }
        }

        StringBuilder sb= new StringBuilder();
        int idx = 0;
        while(idx<order.Length){
            char c = order[idx];
            if(freq.ContainsKey(c) && freq[c] > 0) {
                int count = freq[c];
                while(count>0){
                 sb.Append(c); freq[c]--; 
                 count--;
                }
                 
                 }
            idx++;
        }

       foreach (var kvp in freq){
                 int count = kvp.Value;
                    while (count > 0)
                    {
                        sb.Append(kvp.Key);
                        count--;
                    }
            }

        return sb.ToString();
    }
}