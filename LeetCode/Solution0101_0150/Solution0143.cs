using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0143
{
    public void ReorderList(ListNode head)
    {
        var dummyNode1 = new ListNode(0);
        dummyNode1.next = head;
        var fast = dummyNode1;
        var slow = dummyNode1;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        var dummyNode2 = new ListNode(0);
        var secondHalf = slow.next;
        slow.next = null;

        while (secondHalf != null)
        {
            var temp = secondHalf.next;

            secondHalf.next = dummyNode2.next;
            dummyNode2.next = secondHalf;
            secondHalf = temp;
        }

        var firstHalf = dummyNode1.next;
        secondHalf = dummyNode2.next;
        var curr = new ListNode(0);

        while (firstHalf != null && secondHalf != null)
        {
            curr.next = firstHalf;
            curr = curr.next;
            firstHalf = firstHalf.next;

            curr.next = secondHalf;
            curr = curr.next;
            secondHalf = secondHalf.next;
        }

        if (firstHalf != null)
        {
            curr.next = firstHalf;
        }
    }
}