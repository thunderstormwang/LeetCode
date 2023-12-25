using LeetCode.Models;

namespace LeetCode.Solution0151_0200
{
    public class Solution0160
    {
        public ListNode GetIntersectionNode_Version1(ListNode headA, ListNode headB)
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

        public ListNode GetIntersectionNode_Version2(ListNode headA, ListNode headB)
        {
            var currA = headA;
            var currB = headB;
            var jumpToA = false;
            var jumpToB = false;
            while (currA != null && currB != null)
            {
                if (currA == currB)
                {
                    return currA;
                }

                if (currA.next == null && !jumpToB)
                {
                    currA = headB;
                    jumpToB = true;
                }
                else
                {
                    currA = currA.next;
                }
                
                if (currB.next == null && !jumpToA)
                {
                    currB = headA;
                    jumpToA = true;
                }
                else
                {
                    currB = currB.next;
                }
            }

            return null;
        }

        // 第一個想法是將 list A 和 list B 做反轉, 再從頭開始比較
        // 但題目說不能改變 list 的順序
        // 改變方法, 想辦法找出個別 list 離尾端都剩多樣數量的節點, 那就可以逐一個 node 去比較
        
        // version1: 想辦法找出個別 list 離尾端都剩多樣數量的節點, 那就可以逐一個 node 去比較
        // 個別走過 list A 和 list B 和計算長度
        // 讓長度比較短的 list 先另一邊 list, 且先走 Math.Abs(lengthA - lengthB)
        // ex: list A 長度 5, list B 長度 3, 那麼 list B 走完後須先跳到 list A 再走兩個節點, 
        // list A 走完直接跳至 list B
        // 如此兩條件 list 就剩同樣的長度了
        // 
        // version 2: 同時走兩個 list, 一邊先走 A 再走 B, 一邊先走 B 再走 A
        // 只要兩個 list 有同樣的節點, 那麼最終會同時走到同一個節點上
        // 只是要特別處理 list A 和 list B 的長度一樣且沒交集的 special case(只換交換 list 一次, 避免無窮迴圈)

        // Time: O(N), N = 兩個 linked list 的長度
        // Space: O(1)
    }
}