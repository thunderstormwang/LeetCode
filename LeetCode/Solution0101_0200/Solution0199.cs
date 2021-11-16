using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0199
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            DepthFirstSearch(root,
                1,
                result);

            return result;
        }

        private void DepthFirstSearch(TreeNode root,
            int depth,
            IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            if (result.Count < depth)
            {
                result.Add(root.Val);
            }

            DepthFirstSearch(root.Right,
                depth + 1,
                result);
            DepthFirstSearch(root.Left,
                depth + 1,
                result);
        }
        
        // Time: O(N)
        // Space: O(N)
    }
}