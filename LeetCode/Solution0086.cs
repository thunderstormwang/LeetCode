using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0086
    {
        public ListNode Partition(ListNode head,
            int x)
        {
            var dummyNodeBefore = new ListNode(0);
            var currBefore = dummyNodeBefore;
            var dummyNodeAfter = new ListNode(0);
            var currAfter = dummyNodeAfter;

            var temp = head;
            while (temp != null)
            {
                if (temp.Val < x)
                {
                    var tempNode = new ListNode(temp.Val);
                    currBefore.Next = tempNode;
                    currBefore = currBefore.Next;
                }
                else
                {
                    var tempNode = new ListNode(temp.Val);
                    currAfter.Next = tempNode;
                    currAfter = currAfter.Next;
                }

                temp = temp.Next;
            }

            currBefore.Next = dummyNodeAfter.Next;

            return dummyNodeBefore.Next;
        }
    }
}