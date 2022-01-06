using System;
using System.Collections.Generic;

namespace LeetCode.Solution0201_0500
{
    public class Solution0404
    {
        public int SumOfLeftLeaves_Recursive(TreeNode root)
        {
            return DepthFirstSearch(root,
                false,
                0);
        }

        public int SumOfLeftLeaves_Iterative(TreeNode root)
        {
            var result = 0;
            var stack = new Stack<(TreeNode Node, bool IsLeft)>();

            stack.Push((root, false));
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                var node = item.Node;
                var isLeft = item.IsLeft;

                if (isLeft && node.left == null && node.right == null)
                {
                    result += node.val;
                    continue;
                }

                if (node.right != null)
                {
                    stack.Push((node.right, false));
                }

                if (node.left != null)
                {
                    stack.Push((node.left, true));
                }
            }

            return result;
        }

        private int DepthFirstSearch(TreeNode root,
            bool isLeft,
            int currSum)
        {
            if (isLeft && root.left == null && root.right == null)
            {
                return currSum + root.val;
            }

            if (root.left != null)
            {
                currSum = DepthFirstSearch(root.left,
                    true,
                    currSum);
            }

            if (root.right != null)
            {
                currSum = DepthFirstSearch(root.right,
                    false,
                    currSum);
            }

            return currSum;
        }
    }
}