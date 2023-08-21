using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0142
{
    public ListNode DetectCycle(ListNode head)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var fast = dummyNode;
        var slow = dummyNode;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (slow == fast)
            {
                break;
            }
        }

        if (slow != fast || fast == dummyNode || slow == dummyNode)
        {
            return null;
        }

        fast = dummyNode;
        while (fast != slow)
        {
            fast = fast.next;
            slow = slow.next;
        }

        return slow;
    }
}