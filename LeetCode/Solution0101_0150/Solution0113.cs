using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0113
{
    /// <summary>
    /// Recursive
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public IList<IList<int>> PathSum_Ver1(TreeNode root, int targetSum)
    {
        var result = new List<IList<int>>();

        PreorderSearch(root, targetSum, new List<int>(), result);

        return result;
    }

    private void PreorderSearch(TreeNode root, int targetSum, IList<int> currPath, IList<IList<int>> result)
    {
        if (root == null)
        {
            return;
        }

        targetSum -= root.val;
        currPath.Add(root.val);
        if (targetSum == 0 && root.left == null && root.right == null)
        {
            result.Add(currPath.ToArray());
        }

        PreorderSearch(root.left, targetSum, currPath, result);
        PreorderSearch(root.right, targetSum, currPath, result);

        currPath.RemoveAt(currPath.Count - 1);
    }

    /// <summary>
    /// Iterative
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public IList<IList<int>> PathSum_Ver2(TreeNode root, int targetSum)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        var stack = new Stack<(TreeNode Node, int TargetSum, List<int> CurrPath)>();

        stack.Push((root, targetSum, new List<int>()));
        while (stack.Count != 0)
        {
            var item = stack.Pop();
            item.TargetSum -= item.Node.val;
            item.CurrPath.Add(item.Node.val);
            if (item.Node.left == null && item.Node.right == null && item.TargetSum == 0)
            {
                result.Add(item.CurrPath);
                continue;
            }

            if (item.Node.right != null)
            {
                stack.Push((item.Node.right, item.TargetSum, new List<int>(item.CurrPath.ToArray())));
            }

            if (item.Node.left != null)
            {
                stack.Push((item.Node.left, item.TargetSum, new List<int>(item.CurrPath.ToArray())));
            }
        }

        return result;
    }
}

// Time: O(N)
// Space: O(log(N))