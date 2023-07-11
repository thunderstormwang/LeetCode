using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0143
{
    // todo 精簡化 Ver1
    
    public void ReorderList_Ver1(ListNode head)
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
        var list2 = slow.next;
        slow.next = null;

        while (list2 != null)
        {
            var temp = list2.next;

            list2.next = dummyNode2.next;
            dummyNode2.next = list2;
            list2 = temp;
        }

        var list1 = dummyNode1.next;
        list2 = dummyNode2.next;
        dummyNode1.next = null;
        head = dummyNode1;

        while (list1 != null && list2 != null)
        {
            var temp = list1.next;
            list1.next = null;
            head.next = list1;
            head = head.next;
            list1 = temp;

            temp = list2.next;
            list2.next = null;
            head.next = list2;
            head = head.next;
            list2 = temp;
        }

        if (list1 != null)
        {
            var temp = list1.next;
            list1.next = null;
            head.next = list1;
            head = head.next;
            list1 = temp;
        }
    }

    public void ReorderList(ListNode head)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;

        var secondHalf = CutHalf(dummyNode);
        secondHalf = ReverseNode(secondHalf);

        var firstHalf = dummyNode.next;
        var curr = dummyNode;
        while (firstHalf != null && secondHalf != null)
        {
            curr.next = firstHalf;
            firstHalf = firstHalf.next;
            curr = curr.next;

            curr.next = secondHalf;
            secondHalf = secondHalf.next;
            curr = curr.next;
        }

        while (firstHalf != null)
        {
            curr.next = firstHalf;
            firstHalf = firstHalf.next;
            curr = curr.next;
        }

        while (secondHalf != null)
        {
            curr.next = secondHalf;
            secondHalf = secondHalf.next;
            curr = curr.next;
        }
    }

    private ListNode CutHalf(ListNode dummyNode)
    {
        var fast = dummyNode;
        var slow = dummyNode;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var result = slow.next;
        slow.next = null;
        return result;
    }

    private ListNode ReverseNode(ListNode head)
    {
        ListNode result = null;

        while (head != null)
        {
            var temp = head.next;
            head.next = result;
            result = head;
            head = temp;
        }

        return result;
    }
}