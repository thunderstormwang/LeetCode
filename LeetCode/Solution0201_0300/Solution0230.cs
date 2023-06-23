using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0230
{
    public int KthSmallest_Ver1(TreeNode root, int k)
    {
        var list = new List<int>();

        DepthFirstSearch_Ver1(root, list);

        return list[k - 1];
    }

    private void DepthFirstSearch_Ver1(TreeNode root, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        DepthFirstSearch_Ver1(root.left, list);
        list.Add(root.val);
        DepthFirstSearch_Ver1(root.right, list);
    }

    public int KthSmallest_Ver2(TreeNode root, int k)
    {
        var result = DepthFirstSearch_Ver2(root, 0, k);

        return result.Value;
    }

    private (int Value, int Number) DepthFirstSearch_Ver2(TreeNode root, int number, int k)
    {
        if (root == null)
        {
            return (-1, number);
        }

        var left = DepthFirstSearch_Ver2(root.left, number, k);

        if (left.Number == k)
        {
            return left;
        }

        var rootNumber = left.Number + 1;
        if (rootNumber == k)
        {
            return (root.val, rootNumber);
        }

        return DepthFirstSearch_Ver2(root.right, rootNumber, k);
    }
}