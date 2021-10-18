namespace LeetCode
{
    public class Solution0112
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            return RecursivePathSum(root, sum);
        }

        private bool RecursivePathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return sum == 0;
            }

            if (root.left != null && root.right != null)
            {
                return RecursivePathSum(root.left, sum - root.val) || RecursivePathSum(root.right, sum - root.val);
            }
            else if (root.left == null && root.right != null)
            {
                return RecursivePathSum(root.right, sum - root.val);
            }
            else
            {
                return RecursivePathSum(root.left, sum - root.val);
            }
        }
    }
}