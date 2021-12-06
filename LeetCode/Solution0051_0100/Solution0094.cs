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
            var result = new List<int>();
            var stack = new Stack<TreeNode>();

            while (root != null || stack.Count != 0)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = stack.Pop();
                    result.Add(root.val);
                    root = root.right;
                }
            }

            return result;
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
        
        // Time: O(N)
        // Space: O(N)
        
        // ==========
        
        // 用迭代方式
        // 迭代方式不好想, 要使用 pointer
    }
}