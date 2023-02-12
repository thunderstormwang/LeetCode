namespace LeetCode.Solution0201_0500;

public class Solution0337
{
    public int Rob(TreeNode root)
    {
        var result = Traverse(root);

        return Math.Max(result.Pick, result.NotPick);
    }

    private (int Pick, int NotPick) Traverse(TreeNode root)
    {
        if (root == null)
        {
            return (0, 0);
        }

        var leftResult = Traverse(root.left);
        var rightResult = Traverse(root.right);

        var pickCurrentNode = leftResult.NotPick + rightResult.NotPick + root.val;
        var notPickCurrentNode = leftResult.Pick + rightResult.Pick

        return (pickCurrentNode, notPickCurrentNode);
    }
}