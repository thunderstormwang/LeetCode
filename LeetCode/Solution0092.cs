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
            dummyNode.next = head;

            var leftPreNode = FindNodeByPosition(dummyNode, left - 1);
            var leftNode = leftPreNode.next;

            var rightNode = FindNodeByPosition(dummyNode, right);
            var rightNextNode = rightNode.next;

            leftPreNode.next = null;
            rightNode.next = null;

            var reverse = ReverseList(leftNode);

            leftPreNode.next = reverse;
            leftNode.next = rightNextNode;

            return dummyNode.next;
        }

        private ListNode FindNodeByPosition(ListNode head, int position)
        {
            var result = head;
            var count = 0;
            while (count < position)
            {
                count++;
                result = result.next;
            }

            return result;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = result;
                result = head;
                head = temp;
            }

            return result;
        }
    }
}