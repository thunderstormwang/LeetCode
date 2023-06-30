using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0101
{
    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSymmetric_Ver1(TreeNode root)
    {
        return InorderSearch(root.left, root.right);
    }

    /// <summary>
    /// DFS Iterative
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSymmetric_Ver2(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root.right);
        stack.Push(root.left);

        while (stack.Count > 0)
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
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSymmetric_Ver3(TreeNode root)
    {
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

    private bool InorderSearch(TreeNode left, TreeNode right)
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

        return InorderSearch(left.left, right.right) && InorderSearch(left.right, right.left);
    }
}