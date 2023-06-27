using TreeNode = LeetCode.Models.TreeNode;

namespace LeetCode.Solution0501_0700
{
    public class Solution0513
    {
        public int FindBottomLeftValue_DFS_Recursive(TreeNode root)
        {
            var valueList = new List<int>();
            DepthFirstSearch(root, 1, valueList);

            return valueList.Last();
        }

        public int FindBottomLeftValue_DFS_Iterative(TreeNode root)
        {
            var stack = new Stack<(int Depth, TreeNode Node)>();

            stack.Push((1, root));
            var candidate = stack.Peek();
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                if (item.Depth > candidate.Depth)
                {
                    candidate = item;
                }

                if (item.Node.right != null)
                {
                    stack.Push((item.Depth + 1, item.Node.right));
                }

                if (item.Node.left != null)
                {
                    stack.Push((item.Depth + 1, item.Node.left));
                }
            }

            return candidate.Node.val;
        }

        public int FindBottomLeftValue_BFS(TreeNode root)
        {
            var result = int.MinValue;
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                result = queue.Peek().val;
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

            return result;
        }

        private void DepthFirstSearch(TreeNode root, int depth, List<int> valueList)
        {
            if (root == null)
            {
                return;
            }

            if (valueList.Count < depth)
            {
                valueList.Add(root.val);
            }

            DepthFirstSearch(root.left, depth + 1, valueList);
            DepthFirstSearch(root.right, depth + 1, valueList);
        }
    }
    
    // Time: O(N)
    // Space: O(N)
}