using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0226
{
    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode InvertTree_Ver1(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        (root.left, root.right) = (root.right, root.left);

        InvertTree_Ver1(root.left);
        InvertTree_Ver1(root.right);

        return root;
    }

    /// <summary>
    /// DFS Iterative
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode InvertTree_Ver2(TreeNode root)
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

            (node.left, node.right) = (node.right, node.left);

            stack.Push(node.left);
            stack.Push(node.right);
        }

        return root;
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode InvertTree_Ver3(TreeNode root)
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

            (node.left, node.right) = (node.right, node.left);
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        return root;
    }
}

// Time: O(N)
// Space: O(1)