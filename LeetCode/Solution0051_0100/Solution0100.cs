using System.Collections.Generic;

namespace LeetCode.Solution0051_0100
{
    public class Solution0100
    {
        public bool IsSameTree_DFS_Recursive(TreeNode p,
            TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            return p.val == q.val && IsSameTree_DFS_Recursive(p.left,
                q.left) && IsSameTree_DFS_Recursive(p.right,
                q.right);
        }

        public bool IsSameTree_DFS_Iterative(TreeNode p,
            TreeNode q)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(q);
            stack.Push(p);

            while (stack.Count != 0)
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

                stack.Push(right.right);
                stack.Push(left.right);
                stack.Push(right.left);
                stack.Push(left.left);
            }

            return true;
        }
        
        public bool IsSameTree_BFS(TreeNode p,
            TreeNode q)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(p);
            queue.Enqueue(q);

            while (queue.Count != 0)
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
                queue.Enqueue(right.left);
                queue.Enqueue(left.right);
                queue.Enqueue(right.right);
            }

            return true;
        }
    }
}