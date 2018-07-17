namespace LeetCode
{
    public class Solution100
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (IsSymmetric(root.left) && IsSymmetric(root.right))
            {
                if (root.left == null && root.right == null)
                {
                    return true;
                }
                else if (root.left != null && root.right != null)
                {
                    return root.right.val == root.left.val;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            
        }
    }
}