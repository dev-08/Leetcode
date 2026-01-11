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
    public IList<IList<int>> LevelOrder(TreeNode root) {

IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root == null) return result;
        q.Enqueue(root);
        while(q.Any()){
            int size = q.Count;
          
            IList<int> newl = new List<int>();
        
            for(int i=0;i<size;i++){
                  TreeNode t = q.Dequeue();
                newl.Add(t.val);
                if(t.left!=null )  q.Enqueue(t.left);
                if(t.right!=null)  q.Enqueue(t.right);
            }

            result.Add(newl);
        }

        return result;
    }
}