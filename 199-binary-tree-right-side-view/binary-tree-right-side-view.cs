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
    public IList<int> RightSideView(TreeNode root) {






       if(root == null) return result;
            dfs(root,0);
       return result;
    //    Queue<TreeNode> q = new Queue<TreeNode>();
    //    q.Enqueue(root); 

    //    while(q.Any()){
    //     int size = q.Count;
    //     for(int i=0;i<size;i++){
    //         TreeNode t = q.Dequeue();
    //         if(i==size-1){
    //             result.Add(t.val);
    //         }
    //         if(t.left!=null) q.Enqueue(t.left);
    //         if(t.right!=null)q.Enqueue(t.right);
    //     }
    //    }

    //    return result;

    }

    public void dfs(TreeNode root,int lvl){
        if(root == null) return ;
        if(result.Count == lvl){
            result.Add(root.val);
        }

        dfs(root.right,lvl+1);
        dfs(root.left,lvl+1);
        
    }
}