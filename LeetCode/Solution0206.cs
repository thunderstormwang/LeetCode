namespace LeetCode
{
    public class Solution0206
    {
        public ListNode ReverseList_NonRecursive(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                var temp = head.Next;
                head.Next = result;
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
            if (currNode.Next == null)
            {
                tail = head;
                tail.Next = null;
                return tail;
            }

            head = head.Next;
            tail = ReverseListByRecursive(ref head);
            tail.Next = currNode;
            currNode.Next = null;
            return currNode;
        }
    }
}