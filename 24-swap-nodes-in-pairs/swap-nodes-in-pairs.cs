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
    public ListNode SwapPairs(ListNode head) {
        if(head == null) return null;
        ListNode first = head;
        ListNode second = first.next;
        ListNode temp = first;
       

        while(second!=null )
        {
            if(temp == first ){
                first.next = second.next;
                second.next = first;
                head = second;
            }
            else{
                temp.next = second;
                first.next = second.next;
                second.next = first;
            }
            temp = first;
            first = first.next;
            if(first == null) { second = null ; }
            else{ 
            second = first.next;
            }
        }
        return head;
    }
}