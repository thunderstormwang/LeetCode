using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0144
    {
        public IList<int> PreorderTraversal_Recursive(TreeNode root)
        {
            var result = new List<int>();
            PreorderTraversal(root,
                result);
            return result;
        }

        public IList<int> PreorderTraversal_Iterative(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();

            stack.Push(root);
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                result.Add(node.val);
                stack.Push(node.right);
                stack.Push(node.left);
            }

            return result;
        }

        private void PreorderTraversal(TreeNode root,
            IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            result.Add(root.val);
            PreorderTraversal(root.left,
                result);
            PreorderTraversal(root.right,
                result);
        }
        
        // Time: O(N)
        // Space: O(N)
    }
}