using LeetCode.Models;

namespace LeetCode
{
    public class Solution148
    {
        public ListNode SortList(ListNode head)
        {
            return MergeSort(head);
        }

        private ListNode MergeSort(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var head1 = head;
            var head2 = GetMiddle(head);

            head1 = MergeSort(head1);
            head2 = MergeSort(head2);
            return Merge(head1,
                head2);
        }

        private ListNode GetMiddle(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var slow = dummyNode;
            var fast = dummyNode;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var result = slow.next;
            slow.next = null;
            return result;
        }

        private ListNode Merge(ListNode head1,
            ListNode head2)
        {
            var dummyNode = new ListNode(0);
            var curr = dummyNode;
            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    curr.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    curr.next = head2;
                    head2 = head2.next;
                }

                curr = curr.next;
            }

            if (head1 != null)
            {
                curr.next = head1;
            }

            if (head2 != null)
            {
                curr.next = head2;
            }

            return dummyNode.next;
        }
    }
}