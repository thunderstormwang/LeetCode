namespace LeetCode.Solution0000_0050
{
    public class Solution0024
    {
        public ListNode SwapPairs(ListNode head)
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

        private void SwapNode(ListNode slow,
            ListNode fast)
        {
            var temp = slow.next;
            slow.next = fast;
            temp.next = fast.next;
            fast.next = temp;
        }
        
        // Time: O(N)
        // Space: O(1)
    }
}