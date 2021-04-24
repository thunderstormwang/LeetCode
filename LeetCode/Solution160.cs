using System.Net;
using System.Net.NetworkInformation;

namespace LeetCode
{
    public class Solution160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var headOfA = headA;
            while (headOfA != null)
            {
                var headOfB = headB;
                while (headOfB != null)
                {
                    if (headOfA == headOfB)
                    {
                        return headOfA;
                    }
                    headOfB = headOfB.next;
                }

                headOfA = headOfA.next;
            } 
            
            return null;
        }
    }
}