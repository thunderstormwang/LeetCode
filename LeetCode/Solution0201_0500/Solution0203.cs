namespace LeetCode.Solution0201_0500
{
    public class Solution0203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var preNode = dummyNode;

            while (head != null)
            {
                if (head.val == val)
                {
                    preNode.next = head.next;
                }
                else
                {
                    preNode = head;
                }

                head = head.next;
            }

            return dummyNode.next;
        }
        
        // Time: O(N)
        // Space: O(1)
    }
}