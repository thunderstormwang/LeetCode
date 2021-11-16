namespace LeetCode
{
    public class Solution0141
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}