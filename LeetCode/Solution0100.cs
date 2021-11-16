namespace LeetCode
{
    public class Solution0100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}