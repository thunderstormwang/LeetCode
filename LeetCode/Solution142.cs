using System.Collections.Generic;

namespace LeetCode
{
    public class Solution142
    {
        public ListNode DetectCycle(ListNode head)
        {
            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var fast = dummyNode;
            var slow = dummyNode;
            var fastCount = 0;
            var slowCount = 0;
            var posList = new List<int[]>();

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                fastCount += 2;

                slow = slow.next;
                slowCount += 1;

                if (slow == fast)
                {
                    posList.Add(new int[] { slowCount, fastCount });
                    if (posList.Count == 2)
                    {
                        break;
                    }
                }
            }
            
            if (posList.Count < 2)
            {
                return null;
            }

            var cycleLength = posList[1][0] - posList[0][0];
                
            fast = dummyNode;
            slow = dummyNode;
            var count = 0;
            while (count < cycleLength)
            {
                fast = fast.next;
                count++;
            }

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}