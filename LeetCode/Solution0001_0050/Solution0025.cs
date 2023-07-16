using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0025
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var dummyHead = new ListNode(0);
        dummyHead.next = head;
        var fast = dummyHead;
        var slow = dummyHead;

        while (fast != null)
        {
            var count = k;
            while (count > 0 && fast.next != null)
            {
                fast = fast.next;
                count--;
            }

            if (count > 0)
            {
                return dummyHead.next;
            }

            var curr = slow.next;
            var tail = slow.next;
            slow.next = fast.next;
            fast.next = null;

            while (curr != null)
            {
                var temp = curr.next;
                curr.next = slow.next;
                slow.next = curr;
                curr = temp;
            }

            fast = tail;
            slow = tail;
        }

        return dummyHead.next;
    }
}