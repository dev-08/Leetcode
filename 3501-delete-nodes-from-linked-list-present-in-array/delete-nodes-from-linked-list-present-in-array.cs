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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i<nums.Length;i++){
            set.Add(nums[i]);
        }
        ListNode node = head;
        ListNode prev = head;

        while(node!=null){
            if(set.Contains(node.val)){
                if(node==head){
                    head = head.next;
                    node=head;
                    prev=head;
                }else{
                    ListNode temp = node;
                    node = node.next;
                    prev.next = temp.next;
                    temp.next = null;
                }
            }else{
                if(prev!=node){
                    prev = prev.next;}
                    node = node.next;
                
            }
        }

        return head;
    }
}