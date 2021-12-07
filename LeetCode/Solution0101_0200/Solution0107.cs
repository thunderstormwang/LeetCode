using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0107
    {
        public IList<IList<int>> LevelOrderBottom_BFS(TreeNode root)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeNumInCurrLevel = queue.Count;
                var list = new List<int>();
                while (nodeNumInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        list.Add(node.val);
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                    nodeNumInCurrLevel--;
                }

                if (list.Count != 0)
                {
                    result.Add(list);
                }
            }

            result.Reverse();
            return result;
        }

        public IList<IList<int>> LevelOrderBottom_DFS(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> result = new List<IList<int>>();
            DepthFirst(root,
                result,
                1);
            (result as List<IList<int>>).Reverse();
            return result;
        }

        private void DepthFirst(TreeNode root,
            IList<IList<int>> list,
            int depth)
        {
            if (root == null)
            {
                return;
            }

            if (list.Count < depth)
            {
                list.Add(new List<int>());
            }

            DepthFirst(root.left,
                list,
                depth + 1);
            DepthFirst(root.right,
                list,
                depth + 1);

            list[depth - 1].Add(root.val);
        }
    }
    
    // Time: O(N)
    // Space: O(N)
}