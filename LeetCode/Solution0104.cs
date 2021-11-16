using System;

namespace LeetCode
{
    public class Solution0104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;
        }
    }
}