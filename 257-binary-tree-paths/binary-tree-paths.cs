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
    IList<string> result = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        dfs(root,"",result);
        return result;
    }


    public void dfs(TreeNode root,string path, IList<string> result ){
        if(root == null) return;

        if(string.IsNullOrEmpty(path)) { path = $"{root.val}"; }
        else {path = path + $"->{root.val}" ; }

        if(root.left == null && root.right == null){
            result.Add(path);
        }

        dfs(root.left,path,result);
        dfs(root.right,path,result);
    }
}