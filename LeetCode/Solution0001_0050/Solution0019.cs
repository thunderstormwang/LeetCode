using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0019
{
    public ListNode RemoveNthFromEnd_Ver1(ListNode head, int n)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var fast = dummyNode;
        var slow = dummyNode;

        var count = n + 1;
        while (count > 0)
        {
            fast = fast.next;
            count--;
        }

        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return dummyNode.next;
    }

    public ListNode RemoveNthFromEnd_Ver2(ListNode head, int n)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var fast = dummyNode;
        var slow = dummyNode;

        var count = n;
        while (count > 0)
        {
            fast = fast.next;
            count--;
        }

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return dummyNode.next;
    }
}