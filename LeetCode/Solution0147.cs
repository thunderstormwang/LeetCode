namespace LeetCode
{
    public class Solution0147
    {
        public ListNode InsertionSortList(ListNode head)
        {
            var dummyNode = new ListNode(0);

            while (head != null)
            {
                var pre = dummyNode;
                var curr = dummyNode.Next;

                while (curr != null && curr.Val < head.Val)
                {
                    curr = curr.Next;
                    pre = pre.Next;
                }

                var temp = head.Next;
                pre.Next = head;
                head.Next = curr;
                head = temp;
            }

            return dummyNode.Next;
        }
    }
}