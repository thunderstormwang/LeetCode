namespace LeetCode
{
    public class Solution0061
    {
        public ListNode RotateRight(ListNode head,
            int k)
        {
            if (head == null)
            {
                return head;
            }
            
            var dummyNode = new ListNode(0);
            dummyNode.Next = head;
            var listLength = 0;
            var temp = dummyNode;
            while (temp.Next != null)
            {
                temp = temp.Next;
                listLength++;
            }

            var nthFromEnd = k % listLength;
            if (nthFromEnd == 0)
            {
                return head;
            }

            var position = 0;
            var fast = dummyNode;
            while (position < nthFromEnd)
            {
                fast = fast.Next ?? head;
                position++;
            }

            var slow = dummyNode;
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            fast.Next = head;
            head = slow.Next;
            slow.Next = null;

            return head;
        }
    }
}