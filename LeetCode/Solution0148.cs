using System;
using System.Data;

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
            if (head == null || head.Next == null)
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
            dummyNode.Next = head;
            var slow = dummyNode;
            var fast = dummyNode;
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            var result = slow.Next;
            slow.Next = null;
            return result;
        }

        private ListNode Merge(ListNode head1,
            ListNode head2)
        {
            var dummyNode = new ListNode(0);
            var curr = dummyNode;
            while (head1 != null && head2 != null)
            {
                if (head1.Val < head2.Val)
                {
                    curr.Next = head1;
                    head1 = head1.Next;
                }
                else
                {
                    curr.Next = head2;
                    head2 = head2.Next;
                }

                curr = curr.Next;
            }

            if (head1 != null)
            {
                curr.Next = head1;
            }

            if (head2 != null)
            {
                curr.Next = head2;
            }

            return dummyNode.Next;
        }
    }
}