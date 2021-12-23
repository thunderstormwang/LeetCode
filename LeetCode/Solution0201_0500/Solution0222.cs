using System;

namespace LeetCode.Solution0201_0500
{
    public class Solution0222
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = root.left;
            var leftDepth = 0;
            var right = root.right;
            var rightDepth = 0;

            while (left != null)
            {
                leftDepth++;
                left = left.left;
            }

            while (right != null)
            {
                rightDepth++;
                right = right.right;
            }

            if (leftDepth == rightDepth)
            {
                return ((int)Math.Pow(2,
                    leftDepth) - 1) * 2 + 1;
            }

            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
        
        // Time: O(log(N) * log(N)), 高度最高 log(N) 且每層都可能呼叫 CountNodes
        // Space: O(log(N))
    }
}