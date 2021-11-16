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

            if (root.Left != null && root.Right != null)
            {
                return RecursivePathSum(root.Left, sum - root.Val) || RecursivePathSum(root.Right, sum - root.Val);
            }
            else if (root.Left == null && root.Right != null)
            {
                return RecursivePathSum(root.Right, sum - root.Val);
            }
            else
            {
                return RecursivePathSum(root.Left, sum - root.Val);
            }
        }
    }
}