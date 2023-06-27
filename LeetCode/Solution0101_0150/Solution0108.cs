using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0108
{
    public TreeNode SortedArrayToBST_Ver1(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }

        return PreorderSearch_Ver1(nums, 0, nums.Length - 1);
    }

    private TreeNode PreorderSearch_Ver1(int[] nums, int startIndex, int endIndex)
    {
        TreeNode root = null;
        TreeNode left = null;
        TreeNode right = null;

        if (endIndex - startIndex == 0)
        {
            root = new TreeNode(nums[startIndex]);
            return root;
        }

        if (endIndex - startIndex == 1)
        {
            root = new TreeNode(nums[startIndex]);
            right = new TreeNode(nums[endIndex]);
            root.right = right;
            return root;
        }

        if (endIndex - startIndex == 2)
        {
            root = new TreeNode(nums[startIndex + 1]);
            left = new TreeNode(nums[startIndex]);
            right = new TreeNode(nums[endIndex]);
            root.left = left;
            root.right = right;
            return root;
        }

        int center = (endIndex + startIndex) / 2;

        root = new TreeNode(nums[center]);
        left = PreorderSearch_Ver1(nums, startIndex, center - 1);
        right = PreorderSearch_Ver1(nums, center + 1, endIndex);
        root.left = left;
        root.right = right;
        return root;
    }

    private TreeNode PreorderSearch_Ver2(int [] nums, int start, int end)
    {
        if(end < start)
        {
            return null;
        }

        if(end == start)
        {
            return new TreeNode(nums[start]);
        }

        var rootIndex = (end + start) / 2;
        var root = new TreeNode(nums[rootIndex]);
        root.left = PreorderSearch_Ver2(nums, start, rootIndex - 1);
        root.right = PreorderSearch_Ver2(nums, rootIndex + 1, end);

        return root;
    }

    public TreeNode SortedArrayToBST_Ver2(int[] nums)
    {
        return PreorderSearch_Ver2(nums, 0, nums.Length - 1);
    }
}