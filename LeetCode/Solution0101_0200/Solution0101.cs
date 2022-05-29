using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0101
    {
        public bool IsSymmetric_DFS_Recursive(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return DepthFirstSearch(root.left,
                root.right);
        }

        public bool IsSymmetric_DFS_Iterative(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var stack = new Stack<TreeNode>();
            stack.Push(root.left);
            stack.Push(root.right);
            while (stack.Count > 0 )
            {
                var left = stack.Pop();
                var right = stack.Pop();
                if (left == null && right == null)
                {
                    continue;
                }

                if (left == null || right == null)
                {
                    return false;
                }

                if (left.val != right.val)
                {
                    return false;
                }
                
                stack.Push(right.left);
                stack.Push(left.right);
                stack.Push(right.right);
                stack.Push(left.left);
            }

            return true;
        }

        public bool IsSymmetric_BFS(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
            while (queue.Count > 0)
            {
                var left = queue.Dequeue();
                var right = queue.Dequeue();

                if (left == null && right == null)
                {
                    continue;
                }

                if (left == null || right == null)
                {
                    return false;
                }

                if (left.val != right.val)
                {
                    return false;
                }
                
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
            }

            return true;
        }

        private bool DepthFirstSearch(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return DepthFirstSearch(left.left,
                right.right) && DepthFirstSearch(left.right,
                right.left);
        }

        // Time: O(N)
        // Space: O(N)
    }
}