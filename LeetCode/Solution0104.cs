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

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}