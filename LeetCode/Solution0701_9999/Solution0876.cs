using LeetCode.Models;

namespace LeetCode.Solution0701_9999;

public class Solution0876
{
    public ListNode MiddleNode_Ver1(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }

    public ListNode MiddleNode_Ver2(ListNode head)
    {
        return Recursive(head, head);
    }

    private ListNode Recursive(ListNode fast, ListNode slow)
    {
        if (fast == null || fast.next == null)
        {
            return slow;
        }

        return Recursive(fast.next.next, slow.next);
    }
}