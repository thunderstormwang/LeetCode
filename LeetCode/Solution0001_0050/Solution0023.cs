using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0023
{
    public ListNode MergeKLists_Ver1(ListNode[] lists)
    {
        var dummyNode = new ListNode(0);
        var curr = dummyNode;
        var priorityQueue = new PriorityQueue<ListNode, int>();

        for (var i = 0; i < lists.Length; i++)
        {
            if (lists[i] == null)
            {
                continue;
            }

            priorityQueue.Enqueue(lists[i], lists[i].val);
        }

        while (priorityQueue.Count != 0)
        {
            var node = priorityQueue.Dequeue();
            var temp = node.next;
            curr.next = node;
            curr = curr.next;

            if (temp != null)
            {
                priorityQueue.Enqueue(temp, temp.val);
            }
        }

        return dummyNode.next;
    }

    public ListNode MergeKLists_Ver2(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }

        while (lists.Length > 1)
        {
            var temp = new ListNode[lists.Length / 2 + lists.Length % 2];

            for (var i = 0; i < lists.Length; i += 2)
            {
                temp[i / 2] = Merge(lists[i], i + 1 < lists.Length ? lists[i + 1] : null);
            }

            lists = temp;
        }

        return lists[0];
    }

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode(0);
        var curr = dummyNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                curr = curr.next;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                curr = curr.next;
                list2 = list2.next;
            }
        }

        if (list1 != null)
        {
            curr.next = list1;
        }

        if (list2 != null)
        {
            curr.next = list2;
        }

        return dummyNode.next;
    }
}