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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
      
      ListNode slow = head;
      ListNode fast = head;
      ListNode one = head;

      int i = 1;
      while(i<n){
        if(fast == null) break;
        fast = fast.next;
        i++;
      }


      while(fast.next!=null){
        fast = fast.next;
        if(slow!=one){
            one = one.next;
        }
        slow = slow.next;
      }


      if(slow == one){return head.next;}

        one.next = slow.next;
        slow.next = null;

        return head;

    }
}