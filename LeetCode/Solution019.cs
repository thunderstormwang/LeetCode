namespace LeetCode
{
    public class Solution019
    {
        public ListNode RemoveNthFromEnd(ListNode head,
            int n)
        {
            var fast = head;
            var slow = head;

            var index = 0;
            while (index < n - 1)
            {
                fast = fast.next;
                index++;
            }

            // remove first from head / last from end;
            if (fast.next == null)
            {
                return head.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                if (fast.next == null)
                {
                    break;
                }

                slow = slow.next;
            }

            slow.next = slow.next.next;

            return head;
        }

        public ListNode RemoveNthFromEnd_Old(ListNode head,
            int n)
        {
            var listNodeArray = new ListNode[30];

            var temp = head;
            var index = 0;
            while (temp != null)
            {
                listNodeArray[index] = temp;

                temp = temp.next;
                index++;
            }

            var length = index;
            var targetIndex = length - n;

            // remove last from end;
            if (targetIndex == 0)
            {
                return head.next;
            }

            // remove first from end;
            if (targetIndex == length - 1)
            {
                listNodeArray[targetIndex - 1].next = null;
                return head;
            }

            listNodeArray[targetIndex - 1].next = listNodeArray[targetIndex + 1];

            return head;
        }
    }
}