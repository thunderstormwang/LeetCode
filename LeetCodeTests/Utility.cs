﻿using LeetCode;

namespace LeetCodeTests
{
    public class Utility
    {
        public static TreeNode BuildTree(int?[] input,
            int i)
        {
            if (i >= input.Length || input[i] == null)
            {
                return null;
            }

            var root = new TreeNode(input[i].Value);

            root.left = BuildTree(input,
                2 * i + 1);
            root.right = BuildTree(input,
                2 * i + 2);

            return root;
        }

        public static ListNode BuildListNode(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            var head = new ListNode(array[0]);
            var node = head;

            for (int i = 1; i < array.Length; i++)
            {
                var temp = new ListNode(array[i]);
                node.next = temp;
                node = temp;
            }

            return head;
        }

        public static bool CheckListNode(ListNode list1,
            ListNode list2)
        {
            while (list1 != null || list2 != null)
            {
                var x = list1 != null ? list1.val : -99;
                var y = list2 != null ? list2.val : -99;

                if (x != y)
                {
                    return false;
                }

                list1 = list1 != null ? list1.next : list1;
                list2 = list2 != null ? list2.next : list2;
            }

            return true;
        }
    }
}