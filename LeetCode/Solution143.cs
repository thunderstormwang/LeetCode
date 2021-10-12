using System.Diagnostics.Contracts;

namespace LeetCode
{
    public class Solution143
    {
        public void ReorderList(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;

            var secondHalf = CutHalf(dummyNode);
            secondHalf = ReverseNode(secondHalf);

            var firstHalf = dummyNode.next;
            var curr = dummyNode;
            while (firstHalf != null && secondHalf != null)
            {
                curr.next = firstHalf;
                firstHalf = firstHalf.next;
                curr = curr.next;

                curr.next = secondHalf;
                secondHalf = secondHalf.next;
                curr = curr.next;
            }

            while (firstHalf != null)
            {
                curr.next = firstHalf;
                firstHalf = firstHalf.next;
                curr = curr.next;
            }

            while (secondHalf != null)
            {
                curr.next = secondHalf;
                secondHalf = secondHalf.next;
                curr = curr.next;
            }
        }

        private ListNode CutHalf(ListNode dummyNode)
        {
            var fast = dummyNode;
            var slow = dummyNode;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var result = slow.next;
            slow.next = null;
            return result;
        }

        private ListNode ReverseNode(ListNode head)
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