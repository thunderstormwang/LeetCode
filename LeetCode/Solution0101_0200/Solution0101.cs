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

        /// <summary>
        /// Implement with 2 stack
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric_DFS_Iterative_Version1(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var leftStack = new Stack<TreeNode>();
            var rightStack = new Stack<TreeNode>();
            leftStack.Push(root.left);
            rightStack.Push(root.right);
            while (leftStack.Count > 0 && rightStack.Count > 0)
            {
                var left = leftStack.Pop();
                var right = rightStack.Pop();
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

                leftStack.Push(left.left);
                leftStack.Push(left.right);
                rightStack.Push(right.right);
                rightStack.Push(right.left);
            }

            return leftStack.Count == 0 && rightStack.Count == 0;
        }
        
        /// <summary>
        /// Implement with 1 stack
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric_DFS_Iterative_Version2(TreeNode root)
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

        /// <summary>
        /// Implement with 2 queue
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric_BFS_Version1(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var leftQueue = new Queue<TreeNode>();
            var rightQueue = new Queue<TreeNode>();
            leftQueue.Enqueue(root.left);
            rightQueue.Enqueue(root.right);
            while (leftQueue.Count > 0 && rightQueue.Count > 0)
            {
                var left = leftQueue.Dequeue();
                var right = rightQueue.Dequeue();

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
                
                leftQueue.Enqueue(left.left);
                leftQueue.Enqueue(left.right);
                rightQueue.Enqueue(right.right);
                rightQueue.Enqueue(right.left);
            }

            return leftQueue.Count == 0 && rightQueue.Count == 0;
        }

        /// <summary>
        /// Implement with 1 queue
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric_BFS_Version2(TreeNode root)
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

        private bool DepthFirstSearch(TreeNode left,
            TreeNode right)
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