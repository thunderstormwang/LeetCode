using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0019
    {
        public ListNode RemoveNthFromEnd(ListNode head,
            int n)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var fast = dummyNode;
            var slow = dummyNode;

            var index = 0;
            while (index < n )
            {
                fast = fast.next;
                index++;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return dummyNode.next;
        }
    }
}