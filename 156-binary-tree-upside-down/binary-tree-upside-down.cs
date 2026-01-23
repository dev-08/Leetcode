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
    TreeNode first = null;
    public TreeNode UpsideDownBinaryTree(TreeNode root) {
        dfs(root,null);
        return first;
    }

    public void dfs(TreeNode root, TreeNode parent){
        if(root == null) return;
        dfs(root.left,root);
        dfs(root.right,root);
       if(first == null) { first = root;}
        root.left = parent!=null ?  parent.right : null ;
        root.right = parent!=null ? parent : null ;
        if(parent!=null ){ parent.left = null; }
        if(parent!=null) { parent.right = null; }
    }
}