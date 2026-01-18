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
    public int KthSmallest(TreeNode root, int k) {
     
        bst(root);
        return result[k-1];
        
    }


    public void bst(TreeNode root){
        if(root == null) return;

        bst(root.left);
        result.Add(root.val);
        bst(root.right);
    }
}