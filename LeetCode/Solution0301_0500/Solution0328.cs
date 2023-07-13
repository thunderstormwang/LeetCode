using LeetCode.Models;

namespace LeetCode.Solution0301_0500;

public class Solution0328
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        var oddDummyNode = new ListNode(0);
        oddDummyNode.next = head;
        var oddCurr = oddDummyNode;
        var number = 0;
        var evenDummyNode = new ListNode(0);
        var evenCurr = evenDummyNode;
        ListNode oddEnd = null;
        ListNode evenEnd = null;

        while (head != null)
        {
            number += 1;
            number %= 2;

            if (number == 1)
            {
                oddCurr.next = head;
                oddCurr = oddCurr.next;
                oddEnd = oddCurr;
                head = head.next;
            }
            else
            {
                evenCurr.next = head;
                evenCurr = evenCurr.next;
                evenEnd = evenCurr;
                head = head.next;
            }
        }

        oddEnd.next = evenDummyNode.next;
        evenEnd.next = null;

        return oddDummyNode.next;
    }
}