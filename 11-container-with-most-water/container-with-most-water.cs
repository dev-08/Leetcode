public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int s = 0;
        int e = n-1;
        int currstored = 0;

        while(s<e){
            int minval = Math.Min(height[s],height[e]);
            int total = minval*(e-s);

            if(total>=currstored){
                currstored = total;
            }if(height[s]>height[e]){
                e--;
            }else{
                s++;
            }
        }

        return currstored;
    }
}