using LeetCode.Models;

namespace LeetCode.Solution0101_0200;

public class Solution0102
{
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<IList<int>> LevelOrder_Ver1(TreeNode root)
    {
        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            var nodeNumInCurrLevel = queue.Count;
            var list = new List<int>();
            while (nodeNumInCurrLevel > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    nodeNumInCurrLevel--;
                    continue;
                }

                list.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);

                nodeNumInCurrLevel--;
            }

            if (list.Count != 0)
            {
                result.Add(list);
            }
        }

        return result;
    }

    /// <summary>
    /// DFS Inorder
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<IList<int>> LevelOrder_Ver2(TreeNode root)
    {
        var result = new List<IList<int>>();

        InorderSearch(root, result, 0);

        return result;
    }

    /// <summary>
    /// DFS Prefix
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<IList<int>> LevelOrder_Ver3(TreeNode root)
    {
        var result = new List<IList<int>>();

        PrefixSearch(root, result, 0);

        return result;
    }

    private void InorderSearch(TreeNode root, IList<IList<int>> result, int depth)
    {
        if (root == null)
        {
            return;
        }

        InorderSearch(root.left, result, depth + 1);

        while (depth + 1 > result.Count)
        {
            result.Add(new List<int>());
        }

        result[depth].Add(root.val);

        InorderSearch(root.right, result, depth + 1);
    }
    
    private void PrefixSearch(TreeNode root, IList<IList<int>> result, int depth)
    {
        if(root == null)
        {
            return;
        }

        if(depth + 1 > result.Count )
        {
            result.Add(new List<int>());
        }
        result[depth].Add(root.val);

        PrefixSearch(root.left, result, depth + 1);
        PrefixSearch(root.right, result, depth + 1);
    }
}