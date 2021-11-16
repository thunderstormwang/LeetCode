namespace LeetCode
{
    public class Solution0108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            return GetBST(nums, 0, nums.Length - 1);
        }

        private TreeNode GetBST(int[] nums, int startIndex, int endIndex)
        {
            TreeNode root = null;
            TreeNode left = null;
            TreeNode right = null;

            if (endIndex - startIndex == 2)
            {
                root = new TreeNode(nums[startIndex + 1]);
                left = new TreeNode(nums[startIndex]);
                right = new TreeNode(nums[endIndex]);
                root.Left = left;
                root.Right = right;
                return root;
            }
            else if (endIndex - startIndex == 1)
            {
                root = new TreeNode(nums[startIndex]);
                right = new TreeNode(nums[endIndex]);
                root.Right = right;
                return root;
            }
            else if (endIndex - startIndex == 0)
            {
                root = new TreeNode(nums[startIndex]);
                return root;
            }

            int center = (endIndex + startIndex) / 2;

            root = new TreeNode(nums[center]);
            left = GetBST(nums, startIndex, center - 1);
            right = GetBST(nums, center + 1, endIndex);
            root.Left = left;
            root.Right = right;
            return root;
        }
    }
}