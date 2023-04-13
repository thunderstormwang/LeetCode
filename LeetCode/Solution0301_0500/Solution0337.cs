using LeetCode.Models;

namespace LeetCode.Solution0301_0500;

public class Solution0337
{
    public int Rob(TreeNode root)
    {
        var result = Traverse(root);

        return Math.Max(result.PickCurr, result.NotPickCurr);
    }

    private (int PickCurr, int NotPickCurr) Traverse(TreeNode root)
    {
        if (root == null)
        {
            return (0, 0);
        }

        var leftResult = Traverse(root.left);
        var rightResult = Traverse(root.right);

        var pickCurrentNode = leftResult.NotPickCurr + rightResult.NotPickCurr + root.val;
        var notPickCurrentNode = leftResult.PickCurr + rightResult.PickCurr;

        return (pickCurrentNode, notPickCurrentNode);
    }
}