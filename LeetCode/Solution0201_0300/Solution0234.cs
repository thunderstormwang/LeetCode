using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0234
{
    public bool IsPalindrome(ListNode head)
    {
        var list = new List<int>();

        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        var start = 0;
        var end = list.Count - 1;

        while (start < end)
        {
            if (list[start] != list[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    public bool IsPalindrome_Ver2(ListNode head)
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
        head = slow.next;
        slow.next = null;

        while (head != null)
        {
            var temp = head.next;
            head.next = dummyNode2.next;
            dummyNode2.next = head;
            head = temp;
        }

        var list1 = dummyNode1;
        var list2 = dummyNode2;

        while (list1 != null && list2 != null)
        {
            if (list1.val != list2.val)
            {
                return false;
            }

            list1 = list1.next;
            list2 = list2.next;
        }

        return true;
    }
}