using LeetCode.Models;

namespace LeetCode.Solution0501_9999
{
    public class Solution0617
    {
        public TreeNode MergeTrees_Recursive(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return null;
            }

            var value = 0;
            value += root1?.val ?? 0;
            value += root2?.val ?? 0;
            var result = new TreeNode(value);

            result.left = MergeTrees_Recursive(root1?.left, root2?.left);
            result.right = MergeTrees_Recursive(root1?.right, root2?.right);

            return result;
        }

        public TreeNode MergeTrees_Iterative(TreeNode root1, TreeNode root2)
        {
            var stack = new Stack<TreeNode>();
            var parentStack = new Stack<(TreeNode Parent, bool IsLeft)>();

            var dummyNode = new TreeNode(0);
            parentStack.Push((dummyNode, true));
            stack.Push(root2);
            stack.Push(root1);

            while (stack.Count != 0 && parentStack.Count != 0)
            {
                var node1 = stack.Pop();
                var node2 = stack.Pop();
                var parentItem = parentStack.Pop();

                if (node1 == null && node2 == null)
                {
                    continue;
                }

                var value = 0;
                value += node1?.val ?? 0;
                value += node2?.val ?? 0;
                var mergeNode = new TreeNode(value);

                if (parentItem.IsLeft)
                {
                    parentItem.Parent.left = mergeNode;
                }
                else
                {
                    parentItem.Parent.right = mergeNode;
                }

                parentStack.Push((mergeNode, false));
                stack.Push(node2?.right);
                stack.Push(node1?.right);
                parentStack.Push((mergeNode, true));
                stack.Push(node2?.left);
                stack.Push(node1?.left);
            }

            return dummyNode.left;
        }
    }

    // Time: O(N)
    // Space: O(N)
}