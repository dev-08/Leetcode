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
// public class Solution {
//     bool flag = true;
//     public bool IsSymmetric(TreeNode root) {
//             dfs(root.left , root.right);

//             return flag;
//     }


//     public void dfs(TreeNode left, TreeNode right){
//             if(left == null && right == null) return;

//             if(left == null || right == null || left.val != right.val) { flag = false; return;}

//             dfs(left.left,right.right);
//             dfs(left.right,right.left);


//     }
// }




public class Solution {
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(root.left);
         q.Enqueue(root.right);

        while(q.Any()){
            TreeNode f = q.Dequeue();
            TreeNode s = q.Dequeue();
            if(f==null && s==null) continue;
            if(f==null || s==null || f.val != s.val) return false;

      q.Enqueue(f.left); 
        q.Enqueue(s.right);
          q.Enqueue(f.right);
            q.Enqueue(s.left);
        }


        return true;
    }
}