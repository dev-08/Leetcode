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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> list= new List<double>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Any()){
            int size = q.Count;
            double sum = 0;
            for(int i = 0 ;i<size;i++){
                TreeNode t = q.Dequeue();
                sum = sum + t.val;
                if(t.left!=null) q.Enqueue(t.left);
                if(t.right!=null) q.Enqueue(t.right);
            }

                double avg = (double)sum/size;
                list.Add(avg);
        }

        return list;
        
    }
}