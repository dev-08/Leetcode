public class Solution {

    int [] arr;
    public int Fib(int n) {
        arr = new int[n+1];
  
        Array.Fill(arr, -1);
        return fibona(n);

    }

    public int fibona(int n){
        if(n==1 || n==0 ) return n;
        
        if(arr[n]!=-1) return arr[n];

        arr[n] = fibona(n-1) + fibona(n-2);
        return arr[n];

    }
}