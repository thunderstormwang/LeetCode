using System;
using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode.Solution0101_0150
{
    public class Solution0116
    {
        public TreeNodeV2 Connect_BFS(TreeNodeV2 root)
        {
            var queue = new Queue<TreeNodeV2>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                TreeNodeV2 pre = null;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node == null)
                    {
                        nodeNumberInCurrLevel--;
                        continue;
                    }

                    if (pre != null)
                    {
                        pre.next = node;
                    }

                    pre = node;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                    nodeNumberInCurrLevel--;
                }
            }

            return root;
        }

        public TreeNodeV2 Connect_DFS(TreeNodeV2 root)
        {
            if (root == null)
            {
                return null;
            }

            if (root.left != null)
            {
                root.left.next = root.right;
            }

            if (root.right != null && root.next != null)
            {
                root.right.next = root.next.left;
            }

            Connect_DFS(root.left);
            Connect_DFS(root.right);

            return root;
        }
    }
    
    // Time: O(N)
    // Space: O(1)
}