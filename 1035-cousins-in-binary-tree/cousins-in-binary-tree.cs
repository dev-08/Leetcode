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
    int x_depth = 0;
    int y_depth = 0;
    TreeNode x_parent;
    TreeNode y_parent;
    public bool IsCousins(TreeNode root, int x, int y) {
   
      Queue<TreeNode> q = new Queue<TreeNode>();
      Queue<TreeNode> pq = new Queue<TreeNode>();

        q.Enqueue(root);
        pq.Enqueue(null);

        while(q.Any()){
            int size = q.Count();
            bool xfound = false;
            bool yfound = false;

            TreeNode x_parent = null;
            TreeNode y_parent = null;

                for(int i=0;i<size;i++){
                    TreeNode t = q.Dequeue();
                    TreeNode parent = pq.Dequeue();

                    if(t.val == x){
                        xfound = true;
                        x_parent = parent;
                    }
                     if(t.val == y){
                        yfound = true;
                        y_parent = parent;
                     }

                     if(t.left!=null) { q.Enqueue(t.left); pq.Enqueue(t);}
                     if(t.right!=null){q.Enqueue(t.right); pq.Enqueue(t);}
                }

                  if(xfound && yfound) return x_parent!=y_parent;
    

        }

      
      
            return false;

    }

 

}











// public class Solution {
//     int x_depth = 0;
//     int y_depth = 0;
//     TreeNode x_parent;
//     TreeNode y_parent;
//     public bool IsCousins(TreeNode root, int x, int y) {
   
//         dfs(root,x,y,0,null);
//         return x_depth == y_depth && x_parent!=y_parent;


//     }

//     public void dfs(TreeNode root,int x,int y,int depth,TreeNode parent){
//         if(root == null) return;
//         if(root.val == x) { x_depth = depth; 
//         x_parent = parent;}
//         if(root.val == y) {y_depth = depth; y_parent = parent;}
//         dfs(root.left,x,y,depth+1,root);
//         dfs(root.right,x,y,depth+1,root);
//     }

// }