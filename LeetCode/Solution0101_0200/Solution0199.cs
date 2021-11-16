using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0101_0200
{
    public class Solution0199
    {
        public IList<int> RightSideView_DFS(TreeNode root)
        {
            var result = new List<int>();
            DepthFirstSearch(root,
                1,
                result);

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
            while (queue.Count != 0)
            {
                var array = queue.ToArray();
                queue.Clear();
                result.Add(array[array.Length - 1].Val);

                foreach (var item in array)
                {
                    if (item.Left != null)
                    {
                        queue.Enqueue(item.Left);
                    }
                    
                    if (item.Right != null)
                    {
                        queue.Enqueue(item.Right);
                    }
                }
            }

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