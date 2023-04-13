using LeetCode.Models;

namespace LeetCode.Solution0001_0050
{
    public class Solution0019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var fast = dummyNode;
            var slow = dummyNode;

            var index = 0;
            while (index < n)
            {
                fast = fast.next;
                index++;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return dummyNode.next;
        }
        
        // 這題考你能否找到在一次 traverse 就做完的解法
        
        // Time: O(N)
        // Space: O(1)
    }
}