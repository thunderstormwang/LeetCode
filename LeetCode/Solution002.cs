using System;

namespace LeetCode
{
    public class Solution002
    {
        public ListNode AddTwoNumbers(ListNode l1,
            ListNode l2)
        {
            var result = new ListNode(0);
            var temp = result;
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var x = l1?.val ?? 0;
                var y = l2?.val ?? 0;

                var sum = x + y + carry;
                temp.next = new ListNode(sum % 10);
                carry = sum / 10;
                temp = temp.next;

                l1 = l1 != null ? l1.next : l1;
                l2 = l2 != null ? l2.next : l2;
            }

            if (carry > 0)
            {
                temp.next = new ListNode(1);
            }

            return result.next;
        }
    }
}