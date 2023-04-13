using System.Collections.Generic;
using LeetCode.Models;

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
                if (temp.val < x)
                {
                    var tempNode = new ListNode(temp.val);
                    currBefore.next = tempNode;
                    currBefore = currBefore.next;
                }
                else
                {
                    var tempNode = new ListNode(temp.val);
                    currAfter.next = tempNode;
                    currAfter = currAfter.next;
                }

                temp = temp.next;
            }

            currBefore.next = dummyNodeAfter.next;

            return dummyNodeBefore.next;
        }
    }
}