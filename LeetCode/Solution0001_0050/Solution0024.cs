using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0024
{
    /// <summary>
    /// Iterative
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode SwapPairs_Version1(ListNode head)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var fast = dummyNode.next;
        var slow = dummyNode;

        while (fast != null && fast.next != null)
        {
            var temp = fast.next.next;
            slow.next = fast.next;
            slow.next.next = fast;
            fast.next = temp;

            slow = fast;
            fast = fast.next;
        }

        return dummyNode.next;
    }

    /// <summary>
    /// Recursive
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode SwapPairs_Version2(ListNode head)
    {
        return Recursive(head);
    }

    private ListNode Recursive(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var temp = head.next;
        head.next = Recursive(head.next.next);
        temp.next = head;

        return temp;
    }

    // Time: O(N)
    // Space: O(1)
}