using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0021
{
    public ListNode MergeTwoLists_Ver1(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode(0);
        var curr = dummyNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                var temp = list1;
                curr.next = temp;
                curr = curr.next;
                list1 = list1.next;
            }
            else
            {
                var temp = list2;
                curr.next = temp;
                curr = curr.next;
                list2 = list2.next;
            }
        }

        while (list1 != null)
        {
            var temp = list1;
            curr.next = temp;
            curr = curr.next;
            list1 = list1.next;
        }

        while (list2 != null)
        {
            var temp = list2;
            curr.next = temp;
            curr = curr.next;
            list2 = list2.next;
        }

        return dummyNode.next;
    }

    public ListNode MergeTwoLists_Ver2(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode(0);
        var curr = dummyNode;

        while (list1 != null || list2 != null)
        {
            if (list2 == null || (list1 != null && list1.val <= list2.val))
            {
                var temp = list1;
                list1 = list1.next;
                curr.next = temp;
                curr = curr.next;
            }
            else
            {
                var temp = list2;
                list2 = list2.next;
                curr.next = temp;
                curr = curr.next;
            }
        }

        return dummyNode.next;
    }
}