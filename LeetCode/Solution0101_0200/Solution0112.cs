using System.Collections.Generic;
using TreeNode = LeetCode.Models.TreeNode;

namespace LeetCode.Solution0101_0200
{
    public class Solution0112
    {
        public bool HasPathSum_Recursive(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            return DepthFirstSearch(root, targetSum);
        }

        public bool HasPathSum_Iterative(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            var stack = new Stack<(TreeNode Node, int TargetSum)>();

            stack.Push((root, targetSum));
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                if (item.Node.left == null && item.Node.right == null && item.Node.val == item.TargetSum)
                {
                    return true;
                }

                if (item.Node.right != null)
                {
                    stack.Push((item.Node.right, item.TargetSum - item.Node.val));
                }

                if (item.Node.left != null)
                {
                    stack.Push((item.Node.left, item.TargetSum - item.Node.val));
                }
            }

            return false;
        }

        private bool DepthFirstSearch(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0 == targetSum;
            }

            if (root.left != null && root.right != null)
            {
                return DepthFirstSearch(root.left, targetSum - root.val) 
                       || DepthFirstSearch(root.right, targetSum - root.val);
            }

            if (root.left == null && root.right != null)
            {
                return DepthFirstSearch(root.right, targetSum - root.val);
            }

            if (root.left != null && root.right == null)
            {
                return DepthFirstSearch(root.left, targetSum - root.val);
            }

            return DepthFirstSearch(root.left, targetSum - root.val) 
                   && DepthFirstSearch(root.right, targetSum - root.val);
        }
    }
    
    // Time: O(N)
    // Space: O(log(N))
}