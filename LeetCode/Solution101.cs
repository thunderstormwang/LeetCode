using System.Collections.Generic;

namespace LeetCode
{
    public class Solution101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
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
            else if (left.val != right.val)
            {
                return false;
            }
            else
            {
                return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
            }
        }

        public bool IsSymmetricStack(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root.left);
            stack.Push(root.right);
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
                else if (left.val != right.val)
                {
                    return false;
                }
                else
                {
                    stack.Push(left.left);
                    stack.Push(right.right);
                    stack.Push(left.right);
                    stack.Push(right.left);
                }
            }

            return true;
        }
    }
}