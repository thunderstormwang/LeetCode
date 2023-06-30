using LeetCode.Models;

namespace LeetCode.Solution0051_0100;

public class Solution0100
{
    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public bool IsSameTree_Ver1(TreeNode p, TreeNode q)
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
               && IsSameTree_Ver1(p.left, q.left)
               && IsSameTree_Ver1(p.right, q.right);
    }

    /// <summary>
    /// DFS Iterative
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public bool IsSameTree_Ver2(TreeNode p, TreeNode q)
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

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public bool IsSameTree_Ver3(TreeNode p, TreeNode q)
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