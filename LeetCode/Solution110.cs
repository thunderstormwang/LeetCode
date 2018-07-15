using System;

namespace LeetCode
{
    public class Solution110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int depth;

            return Depth(root, out depth);
        }

        private bool Depth(TreeNode root, out int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }

            int leftDepth;
            bool leftResult;
            int rightDepth;
            bool rightResult;

            leftResult = Depth(root.left, out leftDepth);
            rightResult = Depth(root.right, out rightDepth);
            depth = Math.Max(leftDepth, rightDepth) + 1;

            if (leftResult && rightResult && Math.Abs(leftDepth - rightDepth) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}