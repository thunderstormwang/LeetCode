using LeetCode.Models;

namespace LeetCode.Solution0501_0700;

public class Solution0662
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        return PreorderSearch(root, 0, 0, new List<int>());
    }

    private int PreorderSearch(TreeNode root, int depth, int id, List<int> list)
    {
        if (root == null)
        {
            return 0;
        }

        if (list.Count - 1 < depth)
        {
            list.Add(id);
        }

        var currWidth = id - list[depth] + 1;
        var left = PreorderSearch(root.left, depth + 1, 2 * id, list);
        var right = PreorderSearch(root.right, depth + 1, 2 * id + 1, list);

        return Math.Max(currWidth, Math.Max(left, right));
    }
}