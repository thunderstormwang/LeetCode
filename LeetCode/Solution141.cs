﻿namespace LeetCode
{
    public class Solution141
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}