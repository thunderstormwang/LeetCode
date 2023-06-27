using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0236
{
    public TreeNode LowestCommonAncestor_Ver1(TreeNode root, TreeNode p, TreeNode q)
    {
        var foundP = false;
        var foundQ = false;
        return PostorderSearch(root, p, q, out foundP, out foundQ);
    }

    public TreeNode LowestCommonAncestor_Ver2(TreeNode root, TreeNode p, TreeNode q)
    {
        return PreorderSearch(root, p, q);
    }

    private TreeNode PostorderSearch(TreeNode root, TreeNode p, TreeNode q, out bool foundP, out bool foundQ)
    {
        if (root == null)
        {
            foundP = false;
            foundQ = false;
            return null;
        }

        var leftFoundP = false;
        var leftFoundQ = false;
        var left = PostorderSearch(root.left, p, q, out leftFoundP, out leftFoundQ);
        if (left != null)
        {
            foundP = true;
            foundQ = true;
            return left;
        }

        var rightFoundP = false;
        var rightFoundQ = false;
        var right = PostorderSearch(root.right, p, q, out rightFoundP, out rightFoundQ);
        if (right != null)
        {
            foundP = true;
            foundQ = true;
            return right;
        }

        foundP = leftFoundP || rightFoundP || root.val == p.val;
        foundQ = leftFoundQ || rightFoundQ || root.val == q.val;

        return foundP && foundQ ? root : null;
    }

    private TreeNode PreorderSearch(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val == p.val || root.val == q.val)
        {
            return root;
        }

        var left = PreorderSearch(root.left, p, q);
        var right = PreorderSearch(root.right, p, q);

        if (left != null && right != null)
        {
            return root;
        }

        return left == null ? right : left;
    }
}