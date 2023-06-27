using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0235
{
    /// <summary>
    /// 遞迴
    /// </summary>
    /// <param name="root"></param>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public TreeNode LowestCommonAncestor_Ver1(TreeNode root, TreeNode p, TreeNode q)
    {
        if (p.val > q.val)
        {
            (p, q) = (q, p);
        }

        return PreorderSearch(root, p, q);
    }

    private TreeNode PreorderSearch(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root.val > p.val && root.val < q.val)
        {
            return root;
        }

        if (root.val == p.val || root.val == q.val)
        {
            return root;
        }

        if (root.val < p.val && root.val < q.val)
        {
            return PreorderSearch(root.right, p, q);
        }

        return PreorderSearch(root.left, p, q);
    }

    /// <summary>
    /// 迭代
    /// </summary>
    /// <param name="root"></param>
    /// <param name="nodeP"></param>
    /// <param name="nodeQ"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public TreeNode LowestCommonAncestor_Ver2(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != null)
        {
            if (p.val < root.val && q.val < root.val)
            {
                root = root.left;
            }
            else if (p.val > root.val && q.val > root.val)
            {
                root = root.right;
            }
            else
            {
                return root;
            }
        }

        return null;
    }
}