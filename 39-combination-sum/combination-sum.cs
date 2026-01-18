public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
          IList<IList<int>> result = new List<IList<int>>();
          helper(candidates,0,target,new List<int>(), result);
              return result;
    }


    public void helper(int[] candidates,int idx,int target,IList<int> path, IList<IList<int>> result )  {
        if(target<0 || idx == candidates.Length) return ; 
        if(target == 0){
            result.Add(path);
            return;
        }
        helper(candidates,idx+1,target,new List<int>(path),result);
        path.Add(candidates[idx]);
        helper(candidates,idx,target-candidates[idx],new List<int>(path),result);
    }
}