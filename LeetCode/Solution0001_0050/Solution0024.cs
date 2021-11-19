namespace LeetCode.Solution0001_0050
{
    public class Solution0024
    {
        public ListNode SwapPairs_Version1(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var temp = dummyNode;

            while (temp.next != null && temp.next.next != null)
            {
                SwapNode(temp,
                    temp.next.next);

                temp = temp.next.next;
            }

            return dummyNode.next;
        }
        
        public ListNode SwapPairs_Version2(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var temp = dummyNode;

            while (temp.next != null && temp.next.next != null)
            {
                SwapNextTwoNode(temp);

                temp = temp.next.next;
            }

            return dummyNode.next;
        }

        private void SwapNode(ListNode slow,
            ListNode fast)
        {
            var temp = slow.next;
            slow.next = fast;
            temp.next = fast.next;
            fast.next = temp;
        }
        
        private void SwapNextTwoNode(ListNode node)
        {
            var temp = node.next.next;
            node.next.next = temp.next;
            temp.next = node.next;
            node.next = temp;
        }

        // Time: O(N)
        // Space: O(1)
    }
}