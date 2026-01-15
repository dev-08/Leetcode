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
    int x_depth = 0;
    int y_depth = 0;
    TreeNode x_parent;
    TreeNode y_parent;
    public bool IsCousins(TreeNode root, int x, int y) {
   
        dfs(root,x,y,0,null);
        return x_depth == y_depth && x_parent!=y_parent;


    }

    public void dfs(TreeNode root,int x,int y,int depth,TreeNode parent){
        if(root == null) return;
        if(root.val == x) { x_depth = depth; 
        x_parent = parent;}
        if(root.val == y) {y_depth = depth; y_parent = parent;}
        dfs(root.left,x,y,depth+1,root);
        dfs(root.right,x,y,depth+1,root);
    }

}