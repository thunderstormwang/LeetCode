using LeetCode.Models;

namespace LeetCode.Solution0501_0700;

public class Solution0543
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        var result = 0;
        PostorderSearch(root, out result);

        return result;
    }

    private int PostorderSearch(TreeNode root, out int diameter)
    {
        if (root == null)
        {
            diameter = 0;
            return 0;
        }

        var leftDiameter = 0;
        var rightDiameter = 0;
        var left = PostorderSearch(root.left, out leftDiameter);
        var right = PostorderSearch(root.right, out rightDiameter);

        diameter = Math.Max(leftDiameter, rightDiameter);
        diameter = Math.Max(diameter, left + right);

        return Math.Max(left, right) + 1;
    }
}