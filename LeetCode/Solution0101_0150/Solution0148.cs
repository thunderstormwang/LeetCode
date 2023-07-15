using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution148
{
    /// <summary>
    /// Recursive
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode SortList_Ver1(ListNode head)
    {
        return MergeSort(head);
    }

    public ListNode SortList_Ver2(ListNode head)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var n = 0;

        while (head != null)
        {
            head = head.next;
            n++;
        }

        var len = 1;

        while (len < n)
        {
            var pre = dummyNode;
            var curr = dummyNode.next;

            while (curr != null)
            {
                var list1 = curr;
                var list2 = Split(list1, len);
                var temp = Split(list2, len);

                var mergeResult = Merge(list1, list2);

                pre.next = mergeResult.Head;
                mergeResult.End.next = temp;
                pre = mergeResult.End;
                curr = temp;
            }

            len *= 2;
        }

        return dummyNode.next;
    }

    private ListNode MergeSort(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var fast = dummyNode;
        var slow = dummyNode;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        var list1 = dummyNode.next;
        var list2 = slow.next;
        slow.next = null;

        list1 = MergeSort(list1);
        list2 = MergeSort(list2);

        dummyNode.next = null;
        head = dummyNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                head.next = list1;
                head = head.next;
                list1 = list1.next;
            }
            else
            {
                head.next = list2;
                head = head.next;
                list2 = list2.next;
            }
        }

        while (list1 != null)
        {
            head.next = list1;
            head = head.next;
            list1 = list1.next;
        }

        while (list2 != null)
        {
            head.next = list2;
            head = head.next;
            list2 = list2.next;
        }

        return dummyNode.next;
    }

    private ListNode Split(ListNode head, int n)
    {
        var dummyNode = new ListNode(0);
        dummyNode.next = head;
        var pre = dummyNode;

        while (head != null && n > 0)
        {
            pre = head;
            head = head.next;
            n--;
        }

        pre.next = null;

        return head;
    }

    private (ListNode Head, ListNode End) Merge(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode(0);
        var head = dummyNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                head.next = list1;
                list1 = list1.next;
                head = head.next;
            }
            else
            {
                head.next = list2;
                list2 = list2.next;
                head = head.next;
            }
        }

        while (list1 != null)
        {
            head.next = list1;
            list1 = list1.next;
            head = head.next;
        }

        while (list2 != null)
        {
            head.next = list2;
            list2 = list2.next;
            head = head.next;
        }

        return (dummyNode.next, head);
    }
}