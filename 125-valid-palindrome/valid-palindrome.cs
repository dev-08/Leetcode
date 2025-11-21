public class Solution {
    public bool IsPalindrome(string s) {

     string  st = new string(s.Where(char.IsLetterOrDigit).ToArray());
     string final = st.ToLower();
     char[] array = final.ToCharArray();

     int start = 0;
     int end = final.Length-1;
     while(start<end){
        char c = array[start];
        array[start] = array[end];
        array[end] = c;
        start++;
        end--;
     }

     string convetred=  new string(array);
     if(convetred == final){
        return true;
     }
     return false;


    }
}