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

        return DepthFirstSearch(root, p, q);
    }

    private TreeNode DepthFirstSearch(TreeNode root, TreeNode p, TreeNode q)
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
            return DepthFirstSearch(root.right, p, q);
        }

        return DepthFirstSearch(root.left, p, q);
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