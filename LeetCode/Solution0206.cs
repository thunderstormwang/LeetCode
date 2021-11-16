namespace LeetCode
{
    public class Solution0206
    {
        public ListNode ReverseList_NonRecursive(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = result;
                result = head;
                head = temp;
            }

            return result;
        }

        public ListNode ReverseList_Recursive(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ReverseListByRecursive(ref head);
            return head;
        }

        private ListNode ReverseListByRecursive(ref ListNode head)
        {
            ListNode tail = null;
            var currNode = head;
            if (currNode.next == null)
            {
                tail = head;
                tail.next = null;
                return tail;
            }

            head = head.next;
            tail = ReverseListByRecursive(ref head);
            tail.next = currNode;
            currNode.next = null;
            return currNode;
        }
    }
}