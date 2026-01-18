/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }


 */
public class Solution {
    IList<TreeNode> resultP = new List<TreeNode>();
    IList<TreeNode> resultQ = new List<TreeNode>();
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        dfs(root,p,q,new List<TreeNode>());
        resultP.Add(resultP[resultP.Count-1]);

        resultQ.Add(resultQ[resultQ.Count-1]);
        for(int i=0;i<resultP.Count;i++){
            if(resultP[i]!=resultQ[i]){
                return resultP[i-1];
                break;
            }
        } 

        return null;  
    }

    public void dfs(TreeNode root,TreeNode p ,TreeNode q, IList<TreeNode> path){
        if(root == null) return;
        path.Add(root);
        if(root == p) 
        {   resultP = new List<TreeNode>(path);
            }
        if(root == q) 
        {   
            resultQ = new List<TreeNode>(path);
            
            }
        dfs(root.left,p,q,path);
        dfs(root.right,p,q,path);
        path.RemoveAt(path.Count - 1);
    }
}