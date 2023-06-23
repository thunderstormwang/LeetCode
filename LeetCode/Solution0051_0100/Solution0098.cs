using LeetCode.Models;

namespace LeetCode.Solution0051_0100;

public class Solution0098
{
    public bool IsValidBST_Ver1(TreeNode root)
    {
        var list = new List<int>();

        DepthFirstSearch_Ver1(root, list);

        for (var i = 0; i < list.Count - 1; i++)
        {
            if (list[i] >= list[i + 1])
            {
                return false;
            }
        }

        return true;
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

    public object IsValidBST_Ver2(TreeNode root)
    {
        return DepthFirstSearch_Ver2(root, long.MinValue, long.MaxValue);      
    }

    private bool DepthFirstSearch_Ver2(TreeNode root, long minValue, long maxValue)
    {
        if(root == null)
        {
            return true;
        }

        if(minValue >= root.val || maxValue <= root.val)
        {
            return false;
        }

        if(!DepthFirstSearch_Ver2(root.left, minValue, root.val))
        {
            return false;
        }

        if(!DepthFirstSearch_Ver2(root.right, root.val, maxValue))
        {
            return false;
        }

        return true;
    }
}