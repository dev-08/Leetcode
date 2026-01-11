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
    IList<IList<int>> result ;
    public IList<IList<int>> LevelOrder(TreeNode root) {

        result = new List<IList<int>>();
        dfs(root,0);
        return result;

    }

    private void dfs(TreeNode root,int level){
        if(root==null) return;
        if(level == result.Count){
            result.Add(new List<int>());
        }
        result[level].Add(root.val);
        dfs(root.left,level+1);
        dfs(root.right,level+1);
    }
}