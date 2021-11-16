using System;

namespace LeetCode
{
    public class Solution0111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MinDepth(root.Left);
            var right = MinDepth(root.Right);

            if (left + right == 0)
            {
                // 此為 leaf node
                return 1;
            }
            else if (left == 0 && right != 0)
            {
                // 一邊為0, 此不為 leaf node, 須回傳有 left 的那一邊的 depth
                return right + 1;
            }
            else if (left != 0 && right == 0)
            {
                // 一邊為0, 此不為 leat node, 須回傳有 left 的那一邊的 depth
                return left + 1;
            }
            else
            {
                return Math.Min(left, right) + 1;
            }
        }
    }
}