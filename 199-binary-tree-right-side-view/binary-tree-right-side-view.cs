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
    public IList<int> RightSideView(TreeNode root) {
        
       IList<int> result = new List<int>();  
       if(root == null) return result;
       Queue<TreeNode> q = new Queue<TreeNode>();
       q.Enqueue(root); 

       while(q.Any()){
        int size = q.Count;
        for(int i=0;i<size;i++){
            TreeNode t = q.Dequeue();
            if(i==size-1){
                result.Add(t.val);
            }
            if(t.left!=null) q.Enqueue(t.left);
            if(t.right!=null)q.Enqueue(t.right);
        }
       }

       return result;

    }
}