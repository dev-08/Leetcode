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
    IList <int> list = new List<int>();
    bool flag = true;
    TreeNode curr = null;
    TreeNode prev = null;
    public int[] FindMode(TreeNode root) {

    
        dfs(root);
        int currstreak = 0;
        int idx = 0;
        int currnum;
        int maxstreak = 0;
        int i = 0;
        IList <int> newlist = new List<int>();
        currnum = list[0];
        while(i<list.Count){
            if(currnum == list[i]){
                currstreak++;
            }else{
                currnum = list[i];
                currstreak = 1;
            }

           if(currstreak>maxstreak){
           newlist.Clear();
          maxstreak = currstreak;
           }

           if(currstreak == maxstreak){
            newlist.Add(currnum);
           }
           i++;
        }    
     
        return newlist.ToArray();
   
    }

    public void dfs(TreeNode root){
        if(root == null){
            return;
        }
    
        dfs(root.left);
        list.Add(root.val);
        dfs(root.right);

    }
}