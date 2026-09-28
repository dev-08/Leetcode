class Solution {
public:
    int maxArea(vector<int>& height) {
     int n = height.size();
     int maxval = 0 ; 
     int minval = 0;

     int i = 0;
     int j = n-1;

     while(i<j){
        minval = min(height[i] , height[j]);
        int diff = j-i;

        maxval = max(maxval,minval*diff);
        
        if(height[i]<height[j]){
            i++;
        }else{
            j--;
        }
     }

    return maxval;
    }
};