namespace LeetCode
{
    public class Solution0061
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return head;
            }
            
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var listLength = 0;
            var temp = dummyNode;
            while (temp.next != null)
            {
                temp = temp.next;
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
                fast = fast.next ?? head;
                position++;
            }

            var slow = dummyNode;
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            fast.next = head;
            head = slow.next;
            slow.next = null;

            return head;
        }
    }
}