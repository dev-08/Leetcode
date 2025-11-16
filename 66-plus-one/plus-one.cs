public class Solution {
    public int[] PlusOne(int[] digits) {
      int temp = 0;


      for(int i = digits.Length-1;i>=0;i--){
        if(digits[i]<9){
            digits[i]++;
            return digits;
        }
        digits[i]=0;
      }

        int[] newarray = new int[digits.Length+1];
        newarray[0]=1;
        return newarray;
      
    }
}