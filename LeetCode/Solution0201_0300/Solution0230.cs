using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0230
{
    public int KthSmallest_Ver1(TreeNode root, int k)
    {
        var list = new List<int>();

        InorderSearch_Ver1(root, list);

        return list[k - 1];
    }

    private void InorderSearch_Ver1(TreeNode root, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        InorderSearch_Ver1(root.left, list);
        list.Add(root.val);
        InorderSearch_Ver1(root.right, list);
    }

    public int KthSmallest_Ver2(TreeNode root, int k)
    {
        var result = InorderSearch_Ver2(root, k, 0);

        return result.Value;
    }

    private (int Value, int Number) InorderSearch_Ver2(TreeNode root, int k, int count)
    {
        if (root == null)
        {
            return (-1, count);
        }

        var left = InorderSearch_Ver2(root.left, k, count);

        if (left.Number == k)
        {
            return left;
        }

        var rootNumber = left.Number + 1;
        if (rootNumber == k)
        {
            return (root.val, rootNumber);
        }

        return InorderSearch_Ver2(root.right, k, rootNumber);
    }
}