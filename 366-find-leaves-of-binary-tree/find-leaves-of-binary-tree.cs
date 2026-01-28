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
     IList<IList<int>> result = new List<IList<int>> ();
       
    public IList<IList<int>> FindLeaves(TreeNode root) {
       int a =  dfs(root);
        return result;
    }



    public int dfs(TreeNode root){
        if(root == null) return 0 ;
        int a = dfs(root.left);
        int b = dfs(root.right);
        int max = Math.Max(a,b);
        if(result.Count == max){
            IList<int> temp = new List<int>();
            temp.Add(root.val);
            result.Add(temp);
        }else{
            result[max].Add(root.val);
        }

return max+1;
    }
}