using System.Collections.Generic;

namespace LeetCode.Solution0201_9999
{
    public class Solution0226
    {
        public TreeNode InvertTree_DFS_Recursive(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            (root.left, root.right) = (root.right, root.left);

            InvertTree_DFS_Recursive(root.left);
            InvertTree_DFS_Recursive(root.right);

            return root;
        }
        
        public TreeNode InvertTree_DFS_Iterative(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                (node.left, node.right) = (node.right, node.left);
                
                stack.Push(node.left);
                stack.Push(node.right);
            }

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