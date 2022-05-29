using System;
using System.Collections.Generic;

namespace LeetCode.Solution0501_9999
{
    public class Solution0559
    {
        public int MaxDepth_DFS_TopDown(Node root)
        {
            return DepthFirstSearch(root, 0);
        }

        private int DepthFirstSearch(Node root, int depth)
        {
            if (root == null)
            {
                return depth;
            }

            var result = depth + 1;
            if (root.children == null)
            {
                return result;
            }

            foreach (var item in root.children)
            {
                var temp = DepthFirstSearch(item, depth + 1);
                result = Math.Max(result, temp);
            }

            return result;
        }

        public int MaxDepth_DFS_BottomUp(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            var result = 1;
            if (root.children == null)
            {
                return result;
            }

            foreach (var item in root.children)
            {
                var temp = 1 + MaxDepth_DFS_BottomUp(item);
                result = Math.Max(result, temp);
            }

            return result;
        }

        public int MaxDepth_BFS(Node root)
        {
            var queue = new Queue<Node>();
            var result = 0;

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count != 0)
            {
                result++;
                var nodeNumberInCurrLevel = queue.Count;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node.children != null)
                    {
                        foreach (var item in node.children)
                        {
                            if (item != null)
                            {
                                queue.Enqueue(item);
                            }
                        }
                    }

                    nodeNumberInCurrLevel--;
                }
            }

            return result;
        }
    }
}