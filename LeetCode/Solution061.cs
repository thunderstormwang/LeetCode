namespace LeetCode
{
    public class Solution061
    {
        public ListNode RotateRight(ListNode head,
            int k)
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

            var position = 1;
            var fast = head;
            while (position < nthFromEnd)
            {
                fast = fast.next ?? head;
                position++;
            }

            var slow = head;
            var preSlow = dummyNode;
            while (fast.next != null)
            {
                preSlow = slow;
                slow = slow.next;
                fast = fast.next;
            }

            preSlow.next = null;
            fast.next = head;
            head = slow;

            return head;
        }
    }
}