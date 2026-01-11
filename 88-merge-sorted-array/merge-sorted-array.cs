public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int s1 = m-1;
        int s2 = n-1;
        int curr = nums1.Length-1;


        while( n>0 && s2>=0){
                if(curr>=0 && s1<0 && s2>=0){
                    nums1[curr] = nums2[s2];
                    s2--;
                    curr--;
                } else if(s1>=0 && s2>=0 && nums2[s2]>=nums1[s1]){ 
                nums1[curr] = nums2[s2];
                s2--;
                curr--;
            }else{
                nums1[curr] = nums1[s1];
                s1--;
                curr--;
            }
        }

    }
}