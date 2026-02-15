/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
           int global = 0;
           ListNode head=null;
           ListNode node=null;
           while(l1!=null||l2!=null || global >0){
            int ans = 0;
            if(l1==null && l2 == null) 
            {
                ans = global;
            }else if(l1==null) 
            {
                ans = l2.val + global;
            }else if(l2==null)
            {
                ans = l1.val + global;
            }else 
            {
                ans = l1.val+l2.val+global;
                }

            int modulosanslist = ans%10;
            global = ans/10;
            if(head == null) {
                head = new ListNode(modulosanslist);
                node = head;
            }
            else{
                node.next = new ListNode(modulosanslist);
                  node = node.next;
            }
          

            if(l1!=null) l1 = l1.next;
            if(l2!=null) l2 = l2.next;
           }

        return head;
        
    }
}