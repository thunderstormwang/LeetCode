using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0104
{
    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth_Ver1(TreeNode root)
    {
        return PostorderSearch(root);
    }

    private int PostorderSearch(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var left = PostorderSearch(root.left);
        var right = PostorderSearch(root.right);

        return Math.Max(left, right) + 1;
    }

    public int MaxDepth_Ver2(TreeNode root)
    {
        var depth = 0;
        var queue = new Queue<TreeNode>();

        if (root != null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count != 0)
        {
            depth++;
            var nodeNumberInCurrLevel = queue.Count;
            while (nodeNumberInCurrLevel > 0)
            {
                var node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                nodeNumberInCurrLevel--;
            }
        }

        return depth;
    }
}

// DFS
// 雖然 tree 的高度是從最上層開始算起, 但用 DFS 的方法從底層一路算上來較好寫

// Time: O(N)
// Space: O(1)