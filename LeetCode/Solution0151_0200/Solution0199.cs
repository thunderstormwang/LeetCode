using LeetCode.Models;

namespace LeetCode.Solution0151_0150;

public class Solution0199
{
    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> RightSideView_Ver1(TreeNode root)
    {
        var result = new List<int>();
        PreorderSearch(root, 1, result);

        return result;
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> RightSideView_Ver2(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var result = new List<int>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var count = queue.Count;
        while (count != 0)
        {
            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();

                if (i == count - 1)
                {
                    result.Add(node.val);
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            count = queue.Count;
        }

        return result;
    }

    private void PreorderSearch(TreeNode root, int depth, IList<int> result)
    {
        if (root == null)
        {
            return;
        }

        if (result.Count < depth + 1)
        {
            result.Add(root.val);
        }

        PreorderSearch(root.right, depth + 1, result);
        PreorderSearch(root.left, depth + 1, result);
    }

    // DFS
    // Time: O(N)
    // Space: O(N)

    // ======

    // BFS
    // Time: O(N)
    // Space: O(N)
}