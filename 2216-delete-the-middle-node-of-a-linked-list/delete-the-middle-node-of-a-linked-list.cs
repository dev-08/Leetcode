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
    public ListNode DeleteMiddle(ListNode head) {
        ListNode fast = head;
        ListNode one = head;
        ListNode slow = head;


        while(fast!=null && fast.next!=null ){
            fast = fast.next;
            fast = fast.next;
            if(slow != one) { one = one.next;}
            slow = slow.next;
        }

        if(slow == one) 
        { 
            return one.next;
            }

        one.next = slow.next;
        slow.next = null;
        return head;


    }
}