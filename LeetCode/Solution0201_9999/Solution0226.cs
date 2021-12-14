using System.Collections.Generic;

namespace LeetCode.Solution0201_9999
{
    public class Solution0226
    {
        public TreeNode InvertTree_DFS(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            (root.left, root.right) = (root.right, root.left);

            InvertTree_DFS(root.left);
            InvertTree_DFS(root.right);

            return root;
        }

        public TreeNode InvertTree_BFS(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node == null)
                    {
                        nodeNumberInCurrLevel--;
                        continue;
                    }

                    (node.left, node.right) = (node.right, node.left);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);

                    nodeNumberInCurrLevel--;
                }
            }

            return root;
        }
    }
    
    // Time: O(N)
    // Space: O(1)
}