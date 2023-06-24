using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0285
{
    public TreeNode InorderSuccessor_Ver1(TreeNode root, TreeNode p)
    {
        TreeNode pre = null;
        TreeNode successor = null;

        InorderSearch(root, p, ref pre, ref successor);

        return successor;
    }

    public TreeNode InorderSuccessor_Ver2(TreeNode root, TreeNode p)
    {
        TreeNode pre = null;
        TreeNode successor = null;

        PrefixSearch(root, p, ref successor);

        return successor;
    }

    private void InorderSearch(TreeNode root, TreeNode p, ref TreeNode pre, ref TreeNode successor)
    {
        if (root == null)
        {
            return;
        }

        InorderSearch(root.left, p, ref pre, ref successor);
        if (successor != null)
        {
            return;
        }

        if (pre != null && pre.val == p.val)
        {
            successor = root;
            return;
        }

        pre = root;

        InorderSearch(root.right, p, ref pre, ref successor);
    }

    private void PrefixSearch(TreeNode root, TreeNode p, ref TreeNode successor)
    {
        if (root == null)
        {
            return;
        }

        if (root.val > p.val)
        {
            PrefixSearch(root.left, p, ref successor);
            if (successor == null)
            {
                successor = root;
            }
        }
        else
        {
            PrefixSearch(root.right, p, ref successor);
        }
    }
}