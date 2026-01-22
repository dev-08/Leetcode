/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
      int min = int.MaxValue;
      IList<int> result = new List<int>();
    public int MinDiffInBST(TreeNode root) {
         dfs(root);
         int n = result.Count;
         for (int i=0;i<n-1;i++){
            int diff= Math.Abs(result[i] - result[i+1]);
            min = Math.Min(min,diff);
         }
        return min;
    }


    public void dfs(TreeNode root){
        if(root == null) return;
    

        dfs(root.left);
        result.Add(root.val);
        dfs(root.right);
    }
}