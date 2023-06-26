using LeetCode.Models;

namespace LeetCode.Solution0051_0100;

public class Solution0098
{
    public bool IsValidBST_Ver1(TreeNode root)
    {
        var list = new List<int>();

        InorderSearch(root, list);

        for (var i = 0; i < list.Count - 1; i++)
        {
            if (list[i] >= list[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    private void InorderSearch(TreeNode root, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        InorderSearch(root.left, list);
        list.Add(root.val);
        InorderSearch(root.right, list);
    }

    public bool IsValidBST_Ver2(TreeNode root)
    {
        return PrefixSearch(root, long.MinValue, long.MaxValue);      
    }

    private bool PrefixSearch(TreeNode root, long minValue, long maxValue)
    {
        if(root == null)
        {
            return true;
        }

        if(root.val <= minValue || root.val >= maxValue)
        {
            return false;
        }

        if(!PrefixSearch(root.left, minValue, root.val))
        {
            return false;
        }

        if(!PrefixSearch(root.right, root.val, maxValue))
        {
            return false;
        }

        return true;
    }
}