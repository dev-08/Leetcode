public class Solution {
    public int Reverse(int x) {
       
        int rev = 0;
        bool flag = false;
        while(x!=0){
            int a = x%10;
            if(a<0){flag = true;}
        if (rev > int.MaxValue / 10 ||
           (rev == int.MaxValue / 10 && a > 7))
            return 0;

        if (rev < int.MinValue / 10 ||
           (rev == int.MinValue / 10 && a < -8))
            return 0;
            rev = rev*10 + Math.Abs(a);
            x= x/10;
        }

        if(flag) return rev*(-1);
    else return rev;
    }
}