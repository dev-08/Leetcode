public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,IList<string>> map = new Dictionary<string,IList<string>>();
        IList<IList<string>> result = new List<IList<string>>();
        for(int i = 0 ; i<strs.Length;i++){
            char[] charsarr = strs[i].ToCharArray();
            Array.Sort(charsarr);
            string s = new string(charsarr);

            if(map.ContainsKey(s)){
                map[s].Add(strs[i]);
            }else{
                List<string> lists = new List<string>();
                lists.Add(strs[i]);
                map.Add(s,lists);
            }
        }  


        foreach(var item in map){
            result.Add(item.Value);
        } 

        return result;
    }
}