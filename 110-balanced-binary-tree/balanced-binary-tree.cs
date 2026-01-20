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
    bool flag = true;
    public bool IsBalanced(TreeNode root) {
        
       int ans = dfs(root);
       return flag;
    }


    public int dfs(TreeNode root){
        if(root == null) return 0;

        int left = dfs(root.left);
        int right= dfs(root.right);
    if(Math.Abs(left-right) > 1) flag = false;
        return Math.Max(left,right) + 1;
    }
}