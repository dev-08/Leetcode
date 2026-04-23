class Solution {
public:
    bool validPalindrome(string s) {
        int count  = 0;
        int l = 0;
        int r = s.size() - 1;

            while(l<r){
                if(s[l]!=s[r]){
                   return ispal(s,l+1,r) || ispal(s,l,r-1);
                   
                }

                l++;
                r--;
            }

            return true;
    }


    bool ispal(string s,int left, int right){
        
        while(left<right){
            if(s[left]!=s[right]){
                return false;
            }
            left++;
            right --;
        }
        return true;
    }
};