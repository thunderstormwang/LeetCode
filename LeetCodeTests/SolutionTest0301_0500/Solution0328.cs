using LeetCode.Models;

namespace LeetCodeTests.SolutionTest0301_0500;

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

        while (head != null)
        {
            number += 1;
            number %= 2;

            if (number == 1)
            {
                var temp = head.next;
                oddCurr.next = head;
                oddCurr = oddCurr.next;
                oddCurr.next = null;
                oddEnd = oddCurr;
                head = temp;
            }
            else
            {
                var temp = head.next;
                evenCurr.next = head;
                evenCurr = evenCurr.next;
                evenCurr.next = null;
                head = temp;
            }
        }

        oddEnd.next = evenDummyNode.next;

        return oddDummyNode.next;
    }

    public ListNode OddEvenList_Wrong(ListNode head)
    {
        var oddDummyNode = new ListNode(0);
        oddDummyNode.next = head;
        var oddCurr = oddDummyNode;
        var number = 0;
        var evenDummyNode = new ListNode(0);
        var evenCurr = evenDummyNode;
        ListNode oddEnd = null;

        while (head != null)
        {
            number += 1;
            number %= 2;

            if (number == 1)
            {
                var temp = head.next;
                oddCurr.next = head;
                oddCurr = oddCurr.next;
                oddCurr.next = null;
                oddEnd = oddCurr;
                head = temp;
            }
            else
            {
                var temp = head.next;
                evenCurr.next = head;
                evenCurr = evenCurr.next;
                evenCurr.next = null;
                head = temp;
            }
        }

        oddEnd.next = evenDummyNode.next;

        return oddDummyNode.next;
    }
}