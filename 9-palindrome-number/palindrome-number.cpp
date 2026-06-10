class Solution {
public:
    bool isPalindrome(int x) {
            int i;
            double sum = 0;
            int j = x;
        while(x!=0 && x>0){
            i = x%10;
            sum = sum*10 + i;
            x = x/10;
        }

           cout<< "sum is"<<sum; 
        if(sum == j){
            return true;
        }
      
        return false;
    }
};