using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0142
    {
        public ListNode DetectCycle(ListNode head)
        {
            // Floyd Cycle Detection Algorithm

            var dummyNode = new ListNode(0);
            dummyNode.Next = head;
            var fast = dummyNode;
            var slow = dummyNode;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (slow != fast || fast == dummyNode || slow == dummyNode)
            {
                return null;
            }

            fast = dummyNode;
            while (fast != slow)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return slow;
        }
    }
}