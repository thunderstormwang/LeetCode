using System.Collections.Generic;

namespace LeetCode.Solution0501_9999
{
    public class Solution0572
    {
        public bool IsSubtree_DFS_Recursive(TreeNode root,
            TreeNode subRoot)
        {
            if (root == null)
            {
                return false;
            }

            return IsSameTree_DFS_Recursive(root, subRoot) 
                   || IsSubtree_DFS_Recursive(root.left, subRoot) 
                   || IsSubtree_DFS_Recursive(root.right, subRoot);
        }

        public bool IsSubtree_DFS_Iterative(TreeNode root, TreeNode subRoot)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                if (IsSameTree_DFS_Iterative(node, subRoot))
                {
                    return true;
                }

                stack.Push(node.right);
                stack.Push(node.left);
            }

            return false;
        }

        public bool IsSubtree_BFS(TreeNode root, TreeNode subRoot)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }

                if (IsSameTree_BFS(node, subRoot))
                {
                    return true;
                }

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return false;
        }

        private bool IsSameTree_DFS_Recursive(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            return p.val == q.val 
                   && IsSameTree_DFS_Recursive(p.left, q.left) 
                   && IsSameTree_DFS_Recursive(p.right, q.right);
        }

        private bool IsSameTree_DFS_Iterative(TreeNode p, TreeNode q)
        {
            var stack = new Stack<TreeNode>();

            stack.Push(p);
            stack.Push(q);
            while (stack.Count != 0)
            {
                var subRoot = stack.Pop();
                var root = stack.Pop();

                if (root == null && subRoot == null)
                {
                    continue;
                }

                if (root == null || subRoot == null)
                {
                    return false;
                }

                if (root.val != subRoot.val)
                {
                    return false;
                }

                stack.Push(root.right);
                stack.Push(subRoot.right);
                stack.Push(root.left);
                stack.Push(subRoot.left);
            }

            return true;
        }

        private bool IsSameTree_BFS(TreeNode p, TreeNode q)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(p);
            queue.Enqueue(q);
            while (queue.Count != 0)
            {
                var root = queue.Dequeue();
                var subRoot = queue.Dequeue();

                if (root == null && subRoot == null)
                {
                    continue;
                }

                if (root == null || subRoot == null)
                {
                    return false;
                }

                if (root.val != subRoot.val)
                {
                    return false;
                }

                queue.Enqueue(root.left);
                queue.Enqueue(subRoot.left);
                queue.Enqueue(root.right);
                queue.Enqueue(subRoot.right);
            }

            return true;
        }
    }
}