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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        dfs(p,q);
        return flag;
    }

    public void dfs(TreeNode p,TreeNode q){
        if(p==null && q== null){
            return;
        }
        if(p==null || q== null){
            flag = false;
            return;
        }


        if(p.val != q.val){
                  flag = false;
                  return;
        }

        dfs(p.left,q.left);
        dfs(p.right,q.right);
    }
}