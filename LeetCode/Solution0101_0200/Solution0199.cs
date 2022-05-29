using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0199
    {
        public IList<int> RightSideView_DFS(TreeNode root)
        {
            var result = new List<int>();
            DepthFirstSearch(root, 1, result);

            return result;
        }

        public IList<int> RightSideView_BFS(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            var result = new List<int>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            var nodeNumInCurrLevel = queue.Count;
            while (nodeNumInCurrLevel != 0)
            {
                for (var i = 0; i < nodeNumInCurrLevel; i++)
                {
                    var node = queue.Dequeue();

                    if (i == nodeNumInCurrLevel - 1)
                    {
                        result.Add(node.val);
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                nodeNumInCurrLevel = queue.Count;
            }

            return result;
        }

        private void DepthFirstSearch(TreeNode root, int depth, IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            if (result.Count < depth)
            {
                result.Add(root.val);
            }

            DepthFirstSearch(root.right, depth + 1, result);
            DepthFirstSearch(root.left, depth + 1, result);
        }

        // DFS
        // Time: O(N)
        // Space: O(N)

        // ======

        // BFS
        // Time: O(N)
        // Space: O(N)
    }
}