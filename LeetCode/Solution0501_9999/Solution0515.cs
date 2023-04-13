using LeetCode.Models;

namespace LeetCode.Solution0501_9999
{
    public class Solution0515
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();
            var queue = new Queue<TreeNode>();

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                var max = int.MinValue;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    max = Math.Max(max, node.val);

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

                result.Add(max);
            }

            return result;
        }
    }
}