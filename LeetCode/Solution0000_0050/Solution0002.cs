namespace LeetCode.Solution0000_0050
{
    public class Solution0002
    {
        public ListNode AddTwoNumbers(ListNode l1,
            ListNode l2)
        {
            var dummyNode = new ListNode(0);
            var temp = dummyNode;
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var x = l1?.Val ?? 0;
                var y = l2?.Val ?? 0;

                var sum = x + y + carry;
                temp.Next = new ListNode(sum % 10);
                carry = sum / 10;
                temp = temp.Next;

                l1 = l1 != null ? l1.Next : l1;
                l2 = l2 != null ? l2.Next : l2;
            }

            if (carry > 0)
            {
                temp.Next = new ListNode(1);
            }

            return dummyNode.Next;
        }
        
        // 注意最後是否需要進位
        // Time: O(max(l1,l2))
        // Space: 
    }
}