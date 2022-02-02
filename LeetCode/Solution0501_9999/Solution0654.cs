namespace LeetCode.Solution0501_9999
{
    public class Solution0654
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTree(nums,
                0,
                nums.Length - 1);
        }

        private TreeNode ConstructMaximumBinaryTree(int[] nums,
            int begin,
            int end)
        {
            var maxIndex = begin;
            for (var i = begin + 1; i <= end; i++)
            {
                if (nums[maxIndex] < nums[i])
                {
                    maxIndex = i;
                }
            }

            var node = new TreeNode(nums[maxIndex]);
            if (begin < maxIndex)
            {
                node.left = ConstructMaximumBinaryTree(nums,
                    begin,
                    maxIndex - 1);
            }

            if (maxIndex < end)
            {
                node.right = ConstructMaximumBinaryTree(nums,
                    maxIndex + 1,
                    end);
            }

            return node;
        }
    }
    
    // Time: O(N^2)
    // Space: 最差情況下: O(N), 平均: O(log(N))
}