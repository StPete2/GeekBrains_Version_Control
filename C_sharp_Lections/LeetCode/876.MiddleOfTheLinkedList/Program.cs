using System.Collections.Generic;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode (int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode curr1 = head;
        ListNode curr2 = head;
        ListNode result = null;
        int count=0;
        int count2=0;
        while(curr1!=null)
        {
            count++;
            curr1 = curr1.next;
        }
        while(curr2 != null)
        {
            if(count2 == (count/2))
            {
                result = curr2;
            }
            count2++;
            curr2=curr2.next;
        }
        return result;
    }
}

// public class Solution {
//     private int GetCount(ListNode head) {
//         int count = default;
//         do {
//             count++;
//             head = head.next;
//         } while (head != null);
//         return count;
//     }

//     public ListNode MiddleNode(ListNode head) {
//         int count = GetCount(head);
//         for (int i = 0; i < count; i++) {
//             if (i == count / 2) return head;
//             head = head.next;
//         }
//         return null;
//     }
// }
