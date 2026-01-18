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
    int count = 0;
    TreeNode result ;
    public int KthSmallest(TreeNode root, int k) {
        
        bst(root,k);
        return result.val;
    }


    public void bst(TreeNode root,int k){
        if(root == null) return;
      if(result == null){
        bst(root.left,k);
      }
         count++;
         if(count == k) {result = root ;}
         if(result==null){
        bst(root.right,k);
         }
    }
}