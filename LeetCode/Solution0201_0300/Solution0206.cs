using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0206
{
    /// <summary>
    /// Iterative
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList_Ver1(ListNode head)
    {
        var dummyNode = new ListNode(0);
        while (head != null)
        {
            var temp = head.next;
            head.next = dummyNode.next;
            dummyNode.next = head;
            head = temp;
        }

        return dummyNode.next;
    }

    /// <summary>
    /// Recursive
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList_Ver2(ListNode head)
    {
        var dummyNode = new ListNode(0);
        Recursive(dummyNode, head);
        return dummyNode.next;
    }

    /// <summary>
    /// Two Pointer
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList_Ver3(ListNode head)
    {
        if (head == null)
        {
            return head;
        }

        var dummyNode = new ListNode(0);
        var slow = head;
        var fast = head.next;

        while (fast != null)
        {
            slow.next = dummyNode.next;
            dummyNode.next = slow;
            slow = fast;
            fast = fast.next;
        }

        slow.next = dummyNode.next;
        dummyNode.next = slow;

        return dummyNode.next;
    }

    private void Recursive(ListNode dummyNode, ListNode currNode)
    {
        if (currNode == null)
        {
            return;
        }

        var temp = currNode.next;
        currNode.next = dummyNode.next;
        dummyNode.next = currNode;
        Recursive(dummyNode, temp);
    }
}