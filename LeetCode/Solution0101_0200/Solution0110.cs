using System;

namespace LeetCode.Solution0101_0200
{
    public class Solution0110
    {
        public bool IsBalanced_BottomUp(TreeNode root)
        {
            return DepthFirstSearch_BottomUp(root,
                out _);
        }

        public bool IsBalanced_TopDown(TreeNode root)
        {
            return DepthFirstSearch_TopDown(root,
                0,
                out _);
        }

        private bool DepthFirstSearch_BottomUp(TreeNode root,
            out int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }

            var leftResult = DepthFirstSearch_BottomUp(root.left,
                out var leftDepth);
            var rightResult = DepthFirstSearch_BottomUp(root.right,
                out var rightDepth);

            depth = Math.Max(leftDepth,
                rightDepth) + 1;

            return leftResult && rightResult && Math.Abs(leftDepth - rightDepth) <= 1;
        }

        private bool DepthFirstSearch_TopDown(TreeNode root,
            int depth,
            out int childDepth)
        {
            if (root == null)
            {
                childDepth = depth;
                return true;
            }

            var leftResult = DepthFirstSearch_TopDown(root.left,
                depth + 1,
                out var leftDepth);
            var rightResult = DepthFirstSearch_TopDown(root.right,
                depth + 1,
                out var rightDepth);

            childDepth = Math.Max(leftDepth,
                rightDepth);

            return leftResult && rightResult && Math.Abs(leftDepth - rightDepth) <= 1;
        }
    }
}