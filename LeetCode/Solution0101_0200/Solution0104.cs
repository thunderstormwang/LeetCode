using LeetCode.Models;

namespace LeetCode.Solution0101_0200
{
    public class Solution0104
    {
        public int MaxDepth_DFS_BottomUp(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth_DFS_BottomUp(root.left), MaxDepth_DFS_BottomUp(root.right)) + 1;
        }

        public int MaxDepth_DFS_TopDown(TreeNode root)
        {
            return DepthFirstSearch(root, 0);
        }

        public int MaxDepth_BFS(TreeNode root)
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

        private int DepthFirstSearch(TreeNode root, int depth)
        {
            if (root == null)
            {
                return depth;
            }

            return Math.Max(DepthFirstSearch(root.left, depth + 1), DepthFirstSearch(root.right, depth + 1));
        }
    }
    
    // DFS
    // 雖然 tree 的高度是從最上層開始算起, 但用 DFS 的方法從底層一路算上來較好寫
    
    // Time: O(N)
    // Space: O(1)
}