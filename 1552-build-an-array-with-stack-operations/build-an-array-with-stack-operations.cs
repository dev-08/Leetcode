using System.Collections.Generic;

public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        
        List<string> slist = new List<string>();
        int[] stack = new int[target.Length];
        int top = -1;
        int targettop = 0;
int k = 1;
        while(k<=n){
            if(top<stack.Length){
                
                top++;
                stack[top] = k;
                slist.Add("Push");
            }

            Console.WriteLine("target top " + targettop);

            Console.WriteLine("top " +top);

            Console.WriteLine("target[targettop] " + target[targettop] );

            Console.WriteLine("stack[top]" +stack[top]);
            if(targettop == top && target[targettop] != stack[top]){
                
                top--;
               
                slist.Add("Pop");
            }else{
 
                       
                targettop++;
                 if(targettop == target.Length){
                    break;
                 }
            }


            k++;

        }

    return slist;
    }
}