public class Solution {
    public bool IsValid(string s) {

        Stack<char> stack = new Stack<char>();
        for(int i=0;i<s.Length;i++){

        if(s[i] == '('|| s[i] == '[' || s[i] =='{' ) {
               stack.Push(s[i]);  
        }else{
            if(stack.Count>0){
                char top = stack.Peek();
                if((top == '(' && s[i] == ')' )
                || (top == '[' && s[i] == ']')
                || (top == '{' && s[i] == '}')
                ){
                    stack.Pop();
                }else{
                    return false;
                   
                }
            }else{
                return false;
            }
            
           
        }

        }
        if(stack.Count>0){
            return false;
        }
        return true;

    }
}