using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0124
{
    public int MaxPathSum_Ver1(TreeNode root)
    {
        var including = 0;
        var excluding = 0;
        PostorderSearch_Ver1(root, out including, out excluding);

        return Math.Max(including, excluding);
    }

    public object MaxPathSum_Ver2(TreeNode root)
    {
        var result = int.MinValue;
        PostorderSearch_Ver2(root, ref result);

        return result;
    }

    private void PostorderSearch_Ver1(TreeNode root, out int includingSum, out int excludingSum)
    {
        if (root == null)
        {
            includingSum = -1001;
            excludingSum = -1001;
            return;
        }

        var leftIncluding = 0;
        var leftExcluding = 0;
        PostorderSearch_Ver1(root.left, out leftIncluding, out leftExcluding);

        var rightIncluding = 0;
        var rightExcluding = 0;
        PostorderSearch_Ver1(root.right, out rightIncluding, out rightExcluding);

        includingSum = Math.Max(root.val, root.val + leftIncluding);
        includingSum = Math.Max(root.val, root.val + leftIncluding);
        includingSum = Math.Max(includingSum, root.val + rightIncluding);

        excludingSum = Math.Max(leftExcluding, rightExcluding);
        excludingSum = Math.Max(excludingSum, leftIncluding);
        excludingSum = Math.Max(excludingSum, rightIncluding);
        excludingSum = Math.Max(excludingSum, root.val + leftIncluding + rightIncluding);
    }

    private int PostorderSearch_Ver2(TreeNode root, ref int maxPathSum)
    {
        if (root == null)
        {
            return int.MinValue;
        }

        var left = Math.Max(0, PostorderSearch_Ver2(root.left, ref maxPathSum));
        var right = Math.Max(0, PostorderSearch_Ver2(root.right, ref maxPathSum));

        maxPathSum = Math.Max(maxPathSum, root.val + left + right);

        return root.val + Math.Max(left, right);
    }
}