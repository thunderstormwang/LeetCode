using System;
using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode.Solution0101_0150
{
    public class Solution0111
    {
        public int MinDepth_DFS_BottomUp(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftDepth = MinDepth_DFS_BottomUp(root.left);
            var rightDepth = MinDepth_DFS_BottomUp(root.right);

            // 此為 leaf node
            if (leftDepth + rightDepth == 0)
            {
                return 1;
            }

            // 一邊為 0, 此不為 leaf node, 須回傳有 leaf 的那一邊的 depth
            if (leftDepth == 0 || rightDepth == 0)
            {
                return Math.Max(leftDepth ,rightDepth) + 1;
            }

            return Math.Min(leftDepth, rightDepth) + 1;
        }

        public int MinDepth_DFS_TopDown(TreeNode root)
        {
            return DepthFirstSearch(root, 0);
        }

        private int DepthFirstSearch(TreeNode root, int depth)
        {
            if (root == null)
            {
                return depth;
            }

            var leftDepth = DepthFirstSearch(root.left, depth + 1);
            var rightDepth = DepthFirstSearch(root.right, depth + 1);

            if (root.left == null && root.right == null)
            {
                return depth + 1;
            }

            if (root.left != null && root.right != null)
            {
                return Math.Min(leftDepth, rightDepth);
            }

            return root.left != null ? leftDepth : rightDepth;
        }

        public int MinDepth_BFS(TreeNode root)
        {
            var depth = 0;
            var queue = new Queue<TreeNode>();

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count != 0)
            {
                depth++;
                var nodeNumberInCurrLevel = queue.Count;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    nodeNumberInCurrLevel--;
                }
            }

            return depth;
        }

        // DFS
        // 雖然 tree 的高度是從最上層開始算起, 但用 DFS 的方法從底層一路算上來較好寫

        // Time: O(N)
        // Space: O(1)
    }
}