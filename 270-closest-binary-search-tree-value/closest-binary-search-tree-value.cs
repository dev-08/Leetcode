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

   double min = int.MaxValue;
        int ans  = 0;

    public int ClosestValue(TreeNode root, double target) {
        
        dfs(root,target);
       
        

        return ans;
    }


    public void dfs(TreeNode root,double target){
        if(root == null) return;
int round = (int)target;
         
        if(root.val > round){
            dfs(root.left,target);
        }
        double diff = Math.Abs(target - root.val);
            if(diff<min){
                min = diff;
                ans = root.val;
            }
        
        if(root.val<=round){
            dfs(root.right,target);
        }

    }
}