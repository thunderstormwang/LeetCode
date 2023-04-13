using LeetCode.Models;

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
                var curr = dummyNode.next;

                while (curr != null && curr.val < head.val)
                {
                    curr = curr.next;
                    pre = pre.next;
                }

                var temp = head.next;
                pre.next = head;
                head.next = curr;
                head = temp;
            }

            return dummyNode.next;
        }
    }
}