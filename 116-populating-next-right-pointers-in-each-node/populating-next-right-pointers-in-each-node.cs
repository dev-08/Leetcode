/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null) return null;
            dfs(root);
            return root;
    
    }

    public void dfs(Node level){
        if(level.left==null || level.right==null) {return ; }

        level.left.next = level.right;
        if(level.next!=null){
            level.right.next = level.next.left;
        }
        dfs(level.left);
        dfs(level.right);
    }
}


// public class Solution {
//     public Node Connect(Node root) {
//         if(root == null) return null;
//     Node level = root;
//     while(level.left!=null){
//         Node curr = level;
//         while(curr!=null){
//             curr.left.next = curr.right;
//             if(curr.next!=null){
//                 curr.right.next = curr.next.left;
//             }
//             curr = curr.next;
//         }
//         level = level.left;
//     }

//     return root;
//     }
// }


// public class Solution {
//     public Node Connect(Node root) {
//         if (root == null) return null;
//         Queue<Node> q = new Queue<Node>();
//         q.Enqueue(root);
//         while(q.Any()){
//             int size = q.Count;
//             for(int i=0;i<size;i++){
//                Node n =  q.Dequeue();
//                if(i == size-1){
//                n.next = null;
//                }else
// {             n.next = q.Peek();}
//                if(n.left!=null)  q.Enqueue(n.left);
//                if(n.right!=null) q.Enqueue(n.right);
//             }
//         }
//         return root;
//     }
// }