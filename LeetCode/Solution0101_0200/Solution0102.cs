using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var count = queue.Count;
                var list = new List<int>();
                while (count > 0)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        list.Add(node.val);
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }

                    count--;
                }

                if (list.Count != 0)
                {
                    result.Add(list);
                }
            }

            return result;
        }
    }
}