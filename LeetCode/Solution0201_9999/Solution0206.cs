namespace LeetCode.Solution0201_9999
{
    public class Solution0206
    {
        public ListNode ReverseList_NonRecursive(ListNode head)
        {
            var dummyNode = new ListNode(0);
            while (head != null)
            {
                var temp = head.next;
                head.next = dummyNode.next;
                dummyNode.next = head;
                head = temp;
            }

            return dummyNode.next;
        }

        public ListNode ReverseList_Recursive(ListNode head)
        {
            var dummyNode = new ListNode(0);
            Recursive(dummyNode, head);
            return dummyNode.next;
        }

        private void Recursive(ListNode dummyNode,
            ListNode currNode)
        {
            if (currNode == null)
            {
                return;
            }

            var temp = currNode.next;
            currNode.next = dummyNode.next;
            dummyNode.next = currNode;
            Recursive(dummyNode,
                temp);
        }

        // Time: O(N)
        // Space: O(1)
    }
}