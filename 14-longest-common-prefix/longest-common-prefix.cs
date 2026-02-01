public class Solution {
    Node root = new Node();
    public string LongestCommonPrefix(string[] strs) {
            for(int i = 0; i<strs.Length;i++){
                if(strs[i].Length == 0) return "";
                insert(strs[i]);
            }
    StringBuilder sb= new StringBuilder();
    string str = strs[0];
    int idx = 0;
    Node curr = root;
    int count = 0;
    while(idx<str.Length){
        count = 0;
        int index = str[idx] - 'a';
        for(int i =0 ;i<26;i++){
            if(curr.children[i] != null ) { 
                count++ ;
                
                }
        }
        if(count==1){
                sb.Append(str[idx]);
                curr = curr.children[index];
                if(curr.IsEnd) {break;}
        }
        if(count>1){ break;}
        idx++;
    }
        return sb.ToString();

    }

    public void insert(string s){
        Node curr = root;
        for(int i=0;i<s.Length;i++){
            int idx = s[i] - 'a';
            if(curr.children[idx] == null){
                curr.children[idx] = new Node();
            }
            curr = curr.children[idx];
        }
        curr.IsEnd = true;   
    }


}


public class Node{
    public Node [] children ;
    public bool IsEnd;

    public Node(){
        children = new Node[26];
        for(int i = 0; i<26;i++){
            children[i] = null;
        }
        IsEnd = false;
    }
}