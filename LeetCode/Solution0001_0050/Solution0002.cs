using LeetCode.Models;

namespace LeetCode.Solution0001_0050;

public class Solution0002
{
    public ListNode AddTwoNumbers_Ver1(ListNode l1, ListNode l2)
    {
        var dummyNode = new ListNode(0);
        var carry = 0;
        var curr = dummyNode;

        while (l1 != null && l2 != null)
        {
            var temp = l1.val + l2.val + carry;
            carry = temp / 10 >= 1 ? 1 : 0;
            var node = new ListNode(temp % 10);

            curr.next = node;
            curr = node;
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null)
        {
            var temp = l1.val + carry;
            carry = temp / 10 >= 1 ? 1 : 0;
            var node = new ListNode(temp % 10);

            curr.next = node;
            curr = node;
            l1 = l1.next;
        }

        while (l2 != null)
        {
            var temp = l2.val + carry;
            carry = temp / 10 >= 1 ? 1 : 0;
            var node = new ListNode(temp % 10);

            curr.next = node;
            curr = node;
            l2 = l2.next;
        }

        if (carry > 0)
        {
            var node = new ListNode(1);

            curr.next = node;
            curr = node;
        }

        return dummyNode.next;
    }

    public ListNode AddTwoNumbers_Ver2(ListNode l1, ListNode l2)
    {
        var dummyNode = new ListNode(0);
        var curr = dummyNode;
        var carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            var x = l1?.val ?? 0;
            var y = l2?.val ?? 0;

            var sum = x + y + carry;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;

            l1 = l1 != null ? l1.next : l1;
            l2 = l2 != null ? l2.next : l2;
        }

        return dummyNode.next;
    }
}