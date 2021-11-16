using System.Diagnostics.Contracts;

namespace LeetCode
{
    public class Solution0143
    {
        public void ReorderList(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.Next = head;

            var secondHalf = CutHalf(dummyNode);
            secondHalf = ReverseNode(secondHalf);

            var firstHalf = dummyNode.Next;
            var curr = dummyNode;
            while (firstHalf != null && secondHalf != null)
            {
                curr.Next = firstHalf;
                firstHalf = firstHalf.Next;
                curr = curr.Next;

                curr.Next = secondHalf;
                secondHalf = secondHalf.Next;
                curr = curr.Next;
            }

            while (firstHalf != null)
            {
                curr.Next = firstHalf;
                firstHalf = firstHalf.Next;
                curr = curr.Next;
            }

            while (secondHalf != null)
            {
                curr.Next = secondHalf;
                secondHalf = secondHalf.Next;
                curr = curr.Next;
            }
        }

        private ListNode CutHalf(ListNode dummyNode)
        {
            var fast = dummyNode;
            var slow = dummyNode;
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            var result = slow.Next;
            slow.Next = null;
            return result;
        }

        private ListNode ReverseNode(ListNode head)
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