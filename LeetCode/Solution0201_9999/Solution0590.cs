using System.Collections.Generic;

namespace LeetCode.Solution0201_9999
{
    public class Solution0590
    {
        public IList<int> Postorder_Recursive(Node root)
        {
            var result = new List<int>();

            DepthFirstSearch(root,
                result);

            return result;
        }

        public IList<int> Postorder_Iterative(Node root)
        {
            var result = new List<int>();
            var stack = new Stack<Node>();

            stack.Push(root);
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                result.Add(node.val);
                if (node.children == null)
                {
                    continue;
                }

                foreach (var item in node.children)
                {
                    stack.Push(item);
                }
            }

            result.Reverse();

            return result;
        }

        private void DepthFirstSearch(Node root,
            IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    DepthFirstSearch(item,
                        result);
                }
            }

            result.Add(root.val);
        }
    }
}