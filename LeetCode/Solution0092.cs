using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0092
    {
        public ListNode ReverseBetween(ListNode head,
            int left,
            int right)
        {
            var dummyNode = new ListNode(0);
            dummyNode.Next = head;

            var leftPreNode = FindNodeByPosition(dummyNode,
                left - 1);
            var leftNode = leftPreNode.Next;

            var rightNode = FindNodeByPosition(dummyNode,
                right);
            var rightNextNode = rightNode.Next;

            leftPreNode.Next = null;
            rightNode.Next = null;

            var reverse = ReverseList(leftNode);

            leftPreNode.Next = reverse;
            leftNode.Next = rightNextNode;

            return dummyNode.Next;
        }

        private ListNode FindNodeByPosition(ListNode head,
            int position)
        {
            var result = head;
            var count = 0;
            while (count < position)
            {
                count++;
                result = result.Next;
            }

            return result;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                var temp = head.Next;
                head.Next = result;
                result = head;
                head = temp;
            }

            return result;
        }
    }
}