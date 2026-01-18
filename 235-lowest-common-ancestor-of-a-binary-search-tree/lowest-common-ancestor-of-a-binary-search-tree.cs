/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    TreeNode result = null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
            bst(root,p,q);
            return result;
    }

    public void bst(TreeNode root,TreeNode p,TreeNode q){
        if(root==null) return;

        if(p.val < root.val && q.val < root.val){
            bst(root.left,p,q);
        }else if(p.val>root.val && q.val > root.val){
            bst(root.right,p,q);
        }
        else {
            result = root;
        }

       
    }
}