using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.Left, root.Right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left == null || right == null)
            {
                return false;
            }
            else if (left.Val != right.Val)
            {
                return false;
            }
            else
            {
                return IsSymmetric(left.Left, right.Right) && IsSymmetric(left.Right, right.Left);
            }
        }

        public bool IsSymmetricStack(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root.Left);
            stack.Push(root.Right);
            while (stack.Count > 0)
            {
                TreeNode right = stack.Pop();
                TreeNode left = stack.Pop();
                if (left == null && right == null)
                {
                    continue;
                }
                else if (left == null || right == null)
                {
                    return false;
                }
                else if (left.Val != right.Val)
                {
                    return false;
                }
                else
                {
                    stack.Push(left.Left);
                    stack.Push(right.Right);
                    stack.Push(left.Right);
                    stack.Push(right.Left);
                }
            }

            return true;
        }
    }
}