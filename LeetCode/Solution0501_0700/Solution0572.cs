using LeetCode.Models;

namespace LeetCode.Solution0501_0700;

public class Solution0572
{
    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="root"></param>
    /// <param name="subRoot"></param>
    /// <returns></returns>
    public bool IsSubtree_Ver1(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
        {
            return false;
        }

        return IsSameTree_InorderSearch_Ver1(root, subRoot) 
               || IsSubtree_Ver1(root.left, subRoot) 
               || IsSubtree_Ver1(root.right, subRoot);
    }

    /// <summary>
    /// DFS Iterative
    /// </summary>
    /// <param name="root"></param>
    /// <param name="subRoot"></param>
    /// <returns></returns>
    public bool IsSubtree_Ver2(TreeNode root, TreeNode subRoot)
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

            if (IsSameTree_InorderSearch_Ver2(node, subRoot))
            {
                return true;
            }

            stack.Push(node.right);
            stack.Push(node.left);
        }

        return false;
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <param name="subRoot"></param>
    /// <returns></returns>
    public bool IsSubtree_Ver3(TreeNode root, TreeNode subRoot)
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

    private bool IsSameTree_InorderSearch_Ver1(TreeNode p, TreeNode q)
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
               && IsSameTree_InorderSearch_Ver1(p.left, q.left) 
               && IsSameTree_InorderSearch_Ver1(p.right, q.right);
    }

    private bool IsSameTree_InorderSearch_Ver2(TreeNode p, TreeNode q)
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