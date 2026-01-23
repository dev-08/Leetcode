public class Solution {
    int [] arr;
    public int ClimbStairs(int n) {
        arr = new int[n+1];
    Array.Fill(arr,-1);
        return cs(n);
    }

    public int cs(int n ){
        if(n==1 || n==0) return 1;

        if(arr[n]!=-1) return arr[n];

        arr[n] = cs(n-1) + cs(n-2);
        return arr[n];
    }
}