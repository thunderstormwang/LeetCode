using System;
using System.Net;
using System.Net.NetworkInformation;

namespace LeetCode
{
    public class Solution0160
    {
        public ListNode GetIntersectionNode(ListNode headA,
            ListNode headB)
        {
            var dummyA = new ListNode(0);
            dummyA.next = headA;
            
            var dummyB = new ListNode(0);
            dummyB.next = headB;
            
            var traverseA = dummyA;
            var traverseB = dummyB;

            var lengthA = 0;
            var lengthB = 0;
            
            while (traverseA.next != null )
            {
                traverseA = traverseA.next;
                lengthA++;
            }
            
            while (traverseB.next != null )
            {
                traverseB = traverseB.next;
                lengthB++;
            }

            if (lengthA > lengthB)
            {
                var diff = 0;
                traverseB = dummyA.next;
                while (diff < Math.Abs(lengthA - lengthB))
                {
                    traverseB = traverseB.next;
                    diff++;
                }

                traverseA = dummyB.next;
            }
            else if(lengthA < lengthB)
            {
                var diff = 0;
                traverseA = dummyB.next;
                while (diff < Math.Abs(lengthA - lengthB))
                {
                    traverseA = traverseA.next;
                    diff++;
                }
                
                traverseB = dummyA.next;
            }
            else
            {
                traverseA = dummyB.next;
                traverseB = dummyA.next;
            }

            while (traverseA != null && traverseB != null)
            {
                if (traverseA == traverseB)
                {
                    return traverseA;
                }

                traverseA = traverseA.next;
                traverseB = traverseB.next;
            }

            return null;
        }
    }
}