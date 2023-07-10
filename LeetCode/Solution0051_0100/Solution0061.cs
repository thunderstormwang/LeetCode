using LeetCode.Models;

namespace LeetCode.Solution0051_0100;

public class Solution0061
{
    public ListNode RotateRight_Ver1(ListNode head, int k)
    {
        if (head == null)
        {
            return null;
        }

        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        head = dummyNode;
        var n = 0;

        while (head.next != null)
        {
            head = head.next;
            n++;
        }

        k %= n;

        if (k == 0)
        {
            return dummyNode.next;
        }

        var count = k + 1;
        var fast = dummyNode;
        var slow = dummyNode;

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

        var temp = slow.next;
        slow.next = null;
        slow = temp;

        while (slow.next != null)
        {
            slow = slow.next;
        }

        slow.next = dummyNode.next;
        dummyNode.next = temp;

        return dummyNode.next;
    }

    public ListNode RotateRight_Ver2(ListNode head, int k)
    {
        if (head == null)
        {
            return null;
        }

        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        head = dummyNode;
        var n = 0;

        while (head.next != null)
        {
            head = head.next;
            n++;
        }

        k %= n;

        if (k == 0)
        {
            return dummyNode.next;
        }

        var count = k;
        var fast = dummyNode;
        var slow = dummyNode;

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

        fast.next = dummyNode.next;
        dummyNode.next = slow.next;
        slow.next = null;

        return dummyNode.next;
    }
}