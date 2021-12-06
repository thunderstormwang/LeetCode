using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0145
    {
        public IList<int> PostorderTraversal_Recursive(TreeNode root)
        {
            var result = new List<int>();
            PostorderTraversal(root,
                result);
            return result;
        }

        public IList<int> PostorderTraversal_Iterative(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();

            return result;
        }

        private void PostorderTraversal(TreeNode root,
            IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            PostorderTraversal(root.left,
                result);
            PostorderTraversal(root.right,
                result);
            result.Add(root.val);
        }
    }
}