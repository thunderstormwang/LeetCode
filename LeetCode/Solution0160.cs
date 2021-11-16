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
            dummyA.Next = headA;
            
            var dummyB = new ListNode(0);
            dummyB.Next = headB;
            
            var traverseA = dummyA;
            var traverseB = dummyB;

            var lengthA = 0;
            var lengthB = 0;
            
            while (traverseA.Next != null )
            {
                traverseA = traverseA.Next;
                lengthA++;
            }
            
            while (traverseB.Next != null )
            {
                traverseB = traverseB.Next;
                lengthB++;
            }

            if (lengthA > lengthB)
            {
                var diff = 0;
                traverseB = dummyA.Next;
                while (diff < Math.Abs(lengthA - lengthB))
                {
                    traverseB = traverseB.Next;
                    diff++;
                }

                traverseA = dummyB.Next;
            }
            else if(lengthA < lengthB)
            {
                var diff = 0;
                traverseA = dummyB.Next;
                while (diff < Math.Abs(lengthA - lengthB))
                {
                    traverseA = traverseA.Next;
                    diff++;
                }
                
                traverseB = dummyA.Next;
            }
            else
            {
                traverseA = dummyB.Next;
                traverseB = dummyA.Next;
            }

            while (traverseA != null && traverseB != null)
            {
                if (traverseA == traverseB)
                {
                    return traverseA;
                }

                traverseA = traverseA.Next;
                traverseB = traverseB.Next;
            }

            return null;
        }
    }
}