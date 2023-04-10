namespace LeetCode.Solution0201_0300
{
    public class Solution0257
    {
        public IList<string> BinaryTreePaths_Recursive(TreeNode root)
        {
            IList<string> result = new List<string>();

            DepthFirstSearch(root, string.Empty, result);

            return result;
        }

        public IList<string> BinaryTreePaths_Iterative(TreeNode root)
        {
            IList<string> result = new List<string>();

            var nodeStack = new Stack<TreeNode>();
            var strStack = new Stack<string>();

            nodeStack.Push(root);
            strStack.Push($"{root.val}");
            while (nodeStack.Count != 0)
            {
                var node = nodeStack.Pop();
                var currentPath = strStack.Pop();

                if (node.left == null && node.right == null)
                {
                    result.Add(currentPath);
                    continue;
                }

                if (node.right != null)
                {
                    nodeStack.Push(node.right);
                    strStack.Push($"{currentPath}->{node.right.val}");
                }

                if (node.left != null)
                {
                    nodeStack.Push(node.left);
                    strStack.Push($"{currentPath}->{node.left.val}");
                }
            }

            return result;
        }

        private void DepthFirstSearch(TreeNode root, string currentPath, IList<string> result)
        {
            currentPath += currentPath == string.Empty ? $"{root.val}" : $"->{root.val}";

            if (root.left == null && root.right == null)
            {
                result.Add(currentPath);
                return;
            }

            if (root.left != null)
            {
                DepthFirstSearch(root.left, currentPath, result);
            }

            if (root.right != null)
            {
                DepthFirstSearch(root.right, currentPath, result);
            }
        }
        
        // Time: O(N)
        // Space: 應該是用 tree 的高度去算吧, O(N)
    }
}