public class Solution {
    public string ReverseWords(string s) {
        string [] all = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);

        int left  = 0;
        int right = all.Length-1;

        while(left<=right){
            if(all[left] == ""){
                left++;
            }
            if(all[right] == ""){
                right--;
            }
            string temp = all[left];
            all[left] = all[right];
            all[right] = temp;
            left++;
            right--;
        }

        StringBuilder sb = new StringBuilder();
        int n = all.Length;
        bool flag = false;
        for(int i = 0;i<n;i++){
            if(!string.IsNullOrEmpty(all[i]))
            {
                if(flag) {
                    sb.Append(" ");
                }
                sb.Append(all[i]);
                flag = true;
            }
        }
        
        return sb.ToString();
    }
}