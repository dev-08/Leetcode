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
    TreeNode prev;
    TreeNode curr;
    TreeNode first;
    TreeNode second;
    public void RecoverTree(TreeNode root) {
        if(root == null) return;
        inorder(root);
        int temp = first.val;
        first.val = second.val;
        second.val = temp;
        
    }


    public void inorder(TreeNode root){
        if(root == null) return;
        inorder(root.left);
        prev = curr;
        curr = root;
        if(prev!=null && curr!=null && prev.val > curr.val){
            if(first==null) {first = prev; second = curr;}
            else{ second = curr;}
        }

        inorder(root.right);
    }
}