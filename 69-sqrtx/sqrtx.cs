public class Solution {
    public int MySqrt(int x) {

            int s = 0;
            int e = x;
            int  mid = s+ (e-s)/2;
            int ans = 0;

            while(s<=e){
            
            long square = (long)mid*mid;

            if( square == x) return mid;
            
             if(square > x){

                    e = mid-1;
                }if(square<=x){
                    ans = mid;
                    s= mid+1 ;
                }
                mid = s+ (e-s)/2;    
 
            }
      
        return ans;
    }
}