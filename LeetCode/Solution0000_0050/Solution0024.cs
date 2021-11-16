namespace LeetCode.Solution0000_0050
{
    public class Solution0024
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.Next = head;
            var temp = dummyNode;
           
            while (temp.Next != null && temp.Next.Next != null)
            {
                SwapNode(temp,
                    temp.Next.Next);

                temp = temp.Next.Next;
            }

            return dummyNode.Next;
        }

        private void SwapNode(ListNode slow,
            ListNode fast)
        {
            var temp = slow.Next;
            slow.Next = fast;
            temp.Next = fast.Next;
            fast.Next = temp;
        }
        
        // Time: O(N)
        // Space: O(1)
    }
}