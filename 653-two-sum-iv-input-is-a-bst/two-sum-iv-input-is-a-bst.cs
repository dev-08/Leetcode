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
    HashSet<int> h = new  HashSet<int>();
    bool flag = false;
    public bool FindTarget(TreeNode root, int k) {
        if(root == null){return flag; }
        dfs(root,k);
        return flag;

    }


    public void dfs(TreeNode root, int k){
        if(root == null) return;
        int a = k - root.val;

        if(h.Contains(a)) { flag = true; return;}
        if(!h.Contains(root.val)) { h.Add(root.val);}

        dfs(root.left,k);
        dfs(root.right,k);
        
    }
}