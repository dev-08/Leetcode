public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0;
        int sloap = 0;
        for(int i = 0 ;i<gain.Length;i++){
         
            sloap = sloap + gain[i];
               max  = Math.Max(max,sloap);
        }

        return max;
    }
}