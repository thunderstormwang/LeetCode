using LeetCode.Models;

namespace LeetCode.Solution0101_0200;

public class Solution0110
{
    /// <summary>
    /// DFS 計算高度
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsBalanced_Ver1(TreeNode root)
    {
        return DepthFirstSearch_Ver1(root, out _);
    }

    /// <summary>
    /// DFS 計算深度
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsBalanced_Ver2(TreeNode root)
    {
        return DepthFirstSearch_Ver2(root, 0, out _);
    }

    private bool DepthFirstSearch_Ver1(TreeNode root, out int height)
    {
        if (root == null)
        {
            height = 0;
            return true;
        }

        var leftResult = DepthFirstSearch_Ver1(root.left, out var leftHeight);
        var rightResult = DepthFirstSearch_Ver1(root.right, out var rightHeight);

        height = Math.Max(leftHeight, rightHeight) + 1;

        return leftResult && rightResult && Math.Abs(leftHeight - rightHeight) <= 1;
    }

    private bool DepthFirstSearch_Ver2(TreeNode root, int depth, out int childDepth)
    {
        if (root == null)
        {
            childDepth = depth;
            return true;
        }

        var leftResult = DepthFirstSearch_Ver2(root.left, depth + 1, out var leftDepth);
        var rightResult = DepthFirstSearch_Ver2(root.right, depth + 1, out var rightDepth);

        childDepth = Math.Max(leftDepth, rightDepth);

        return leftResult && rightResult && Math.Abs(leftDepth - rightDepth) <= 1;
    }
}