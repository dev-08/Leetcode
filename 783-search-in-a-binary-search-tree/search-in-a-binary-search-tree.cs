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
    TreeNode final ; 
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root.val == val) return root;
        dfs(root,val);
        return final;
    }

    public TreeNode dfs(TreeNode root, int val){
        if(root == null){
            return null;
        }

        TreeNode left = dfs(root.left,val);
        TreeNode right = dfs(root.right,val);
        if(left!=null && left.val == val){
            final = left;
        }
        if(right!=null && right.val == val){
            final = right;
        }
        return root; 
    }
}