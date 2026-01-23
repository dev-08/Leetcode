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

    IList<int> result = new List<int>();

    public int ClosestValue(TreeNode root, double target) {
            double min = int.MaxValue;
        int ans  = 0;

        dfs(root);
        int n = result.Count;
        for(int i=0;i<n;i++){
            double diff = Math.Abs(target - result[i]);
            if(diff<min){
                min = diff;
                ans = result[i];
            }
        }

        return ans;
    }


    public void dfs(TreeNode root){
        if(root == null) return;
        dfs(root.left);
        result.Add(root.val);
        dfs(root.right);
    }
}