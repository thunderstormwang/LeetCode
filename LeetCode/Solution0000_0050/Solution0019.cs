namespace LeetCode.Solution0000_0050
{
    public class Solution0019
    {
        public ListNode RemoveNthFromEnd(ListNode head,
            int n)
        {
            var dummyNode = new ListNode(0);
            dummyNode.Next = head;
            var fast = dummyNode;
            var slow = dummyNode;

            var index = 0;
            while (index < n)
            {
                fast = fast.Next;
                index++;
            }

            while (fast.Next != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            slow.Next = slow.Next.Next;

            return dummyNode.Next;
        }
        
        // 這題考你能否找到在一次 traverse 就做完的解法
        
        // Time: O(N)
        // Space: O(1)
    }
}