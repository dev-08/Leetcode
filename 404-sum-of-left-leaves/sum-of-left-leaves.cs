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
    int sum = 0;
    public int SumOfLeftLeaves(TreeNode root) {
        
        dfs(root,false);
        return sum;
    }

    public void dfs(TreeNode root,bool flag){
        if(root == null) return;
        if(flag&& root.left==null && root.right == null) {
            sum = sum + root.val;
        }
        dfs(root.left,true);
        dfs(root.right,false);
    }
}