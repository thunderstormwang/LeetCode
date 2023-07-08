using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0141
{
    public bool HasCycle_Ver1(ListNode head)
    {
        var hashSet = new HashSet<ListNode>();

        while (head != null)
        {
            if (hashSet.Contains(head))
            {
                return true;
            }

            hashSet.Add(head);
            head = head.next;
        }

        return false;
    }

    public bool HasCycle_Ver2(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        var fast = head.next;
        var slow = head;

        while (fast != null && fast.next != null)
        {
            if (fast == slow)
            {
                return true;
            }

            fast = fast.next.next;
            slow = slow.next;
        }

        return false;
    }

    public bool HasCycle_Ver3(ListNode head)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;

        var fast = dummyNode.next;
        var slow = dummyNode;

        while (fast != null && fast.next != null)
        {
            if (fast == slow)
            {
                return true;
            }

            fast = fast.next.next;
            slow = slow.next;
        }

        return false;
    }
}