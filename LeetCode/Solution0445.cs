using LeetCode.Models;

namespace LeetCode
{
    public class Solution0445
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();
            var tempHead1 = l1;
            var tempHead2 = l2;
            var carry = 0;
            ListNode result = null;

            while (tempHead1 != null)
            {
                stack1.Push(tempHead1.val);
                tempHead1 = tempHead1.next;
            }

            while (tempHead2 != null)
            {
                stack2.Push(tempHead2.val);
                tempHead2 = tempHead2.next;
            }

            while (stack1.Count > 0 || stack2.Count > 0)
            {
                var value1 = stack1.Count > 0 ? stack1.Pop() : 0;
                var value2 = stack2.Count > 0 ? stack2.Pop() : 0;

                var newValue = value1 + value2 + carry;
                carry = newValue / 10;
                var node = new ListNode(newValue % 10);
                node.next = result;
                result = node;
            }

            if (carry > 0) 
            {
                var node = new ListNode(carry);
                node.next = result;
                result = node;
            }

            return result;
        }
    }
}