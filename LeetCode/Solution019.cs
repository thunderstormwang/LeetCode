namespace LeetCode
{
    public class Solution019
    {
        public ListNode RemoveNthFromEnd(ListNode head,
            int n)
        {
            var fast = head;
            var slow = head;

            var index = 0;
            while (index < n - 1)
            {
                fast = fast.next;
                index++;
            }

            // remove first from head / last from end;
            if (fast.next == null)
            {
                return head.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                if (fast.next == null)
                {
                    break;
                }

                slow = slow.next;
            }

            slow.next = slow.next.next;

            return head;
        }
    }
}