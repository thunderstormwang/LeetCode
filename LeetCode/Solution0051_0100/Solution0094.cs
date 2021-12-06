using System.Collections.Generic;

namespace LeetCode.Solution0051_0100
{
    public class Solution0094
    {
        public IList<int> InorderTraversal_Recursive(TreeNode root)
        {
            var result = new List<int>();
            InorderTraversal(root,
                result);
            return result;
        }

        public IList<int> InorderTraversal_Iterative(TreeNode root)
        {
            throw new System.NotImplementedException();
        }

        private void InorderTraversal(TreeNode root,
            IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            InorderTraversal(root.left,
                result);
            result.Add(root.val);
            InorderTraversal(root.right,
                result);
        }
    }
}