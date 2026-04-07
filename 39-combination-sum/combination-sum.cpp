class Solution {
public:   

      
    vector<vector<int>> combinationSum(vector<int>& candidates, int target) {
      
    //      vector<int>path;
    //     vector<vector<int> >ans;
    //     cs(candidates,0,target,path,ans);

    //     return ans;

    // }


    // void cs(vector<int>& candidates,int idx,int target,vector<int> &path,vector<vector<int> > &ans){

    //      if(target == 0){
    //         ans.push_back(path);
    //         return;

    //     }
    //     if(idx == candidates.size() || target<0){
    //         return;

    //     }

    //     path.push_back(candidates[idx]);
    //     cs(candidates,idx,target-candidates[idx],path,ans);
    //     // backtracking
    //     path.pop_back();     
    //     cs(candidates,idx+1,target,path,ans);
       
    

    // }


       int n = candidates.size();
        vector<int> path;
     vector<vector<int>>ans;
     
        cs(candidates,target,0,n,0,path,ans);
      

        return ans;
    }

void cs(vector<int> candidates, int target,int k, int n,int sum,vector<int> &path ,vector<vector<int>> &ans){

        if(sum == target){
            ans.push_back(path);
            return;
        }

        if(sum>target){
            return;
        }
        
       
        
        for(int i=k;i<n;i++){
             sum = sum+candidates[i];
                path.push_back(candidates[i]);
             cs(candidates,target,i,n,sum,path,ans);
             sum = sum - candidates[i]; 
             path.pop_back();  
              
            
        }
     
       
}  
    
};









//    vector<int>path;
//         vector<vector<int> >ans;
//         cs(candidates,0,target,path,ans);

//         return ans;

//     }


//     void cs(vector<int>& candidates,int idx,int target,vector<int> &path,vector<vector<int> > &ans){

//          if(target == 0){
//             ans.push_back(path);
//             return;

//         }
//         if(idx == candidates.size() || target<0){
//             return;

//         }
//         cs(candidates,idx+1,target,path,ans);
//         path.push_back(candidates[idx]);
//         cs(candidates,idx,target-candidates[idx],path,ans);
    

//     }







// class Solution {
// public:

//     vector<vector<int> > ans;
//     vector<vector<int>> combinationSum(vector<int>& candidates, int target) {

//         int n = candidates.size();
//         vector<int> path;
     
//       for(int i=0;i<n;i++){  
//         cs(candidates,target,i,n,0,path);
//       }

//         return ans;
//     }

//     void cs(vector<int> candidates, int target,int k, int n,int sum,vector<int>path){

//         if(sum == target){
//             ans.push_back(path);
//             return;
//         }

//         if(sum>target){
//             return;
//         }

        
       
        
//         for(int i=k;i<n;i++){
//             path.push_back(candidates[i]);
//             cs(candidates,target,i,n,sum+candidates[i],path);
//         }
//     }
// };