﻿using LeetCode.Models;

namespace LeetCode.Solution0501_0700
{
    public class Solution0589
    {
        public IList<int> Preorder_Recursive(Node root)
        {
            var result = new List<int>();

            DepthFirstSearch(root, result);

            return result;
        }

        public IList<int> Preorder_Iterative(Node root)
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

                for (var i = node.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(node.children[i]);
                }
            }

            return result;
        }

        private void DepthFirstSearch(Node root, IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            result.Add(root.val);

            if (root.children == null)
            {
                return;
            }

            foreach (var item in root.children)
            {
                DepthFirstSearch(item, result);
            }
        }
    }

    // Time: O(N)
    // Space: O(N)
}