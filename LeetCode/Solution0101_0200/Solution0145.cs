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

            result.Reverse();

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
        
        // Time: O(N)
        // Space: O(N)
        
        // ==========
        
        // 用迭代方式
        // 迭代方式不好想
        // preorder 的順序是 中左右
        // 如果我們用 preorder 且先去訪問右節點, 那順序是 中右左,
        // 反轉後變成 左右中, 正好是 postorder 的順序
    }
}