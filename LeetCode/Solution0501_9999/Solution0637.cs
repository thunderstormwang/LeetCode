using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode.Solution0501_9999
{
    public class Solution0637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeCountInCurrLevel = queue.Count;
                var levelSum = 0d;
                for (var i = 0; i < nodeCountInCurrLevel; i++)
                {
                    var node = queue.Dequeue();

                    levelSum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(levelSum / (double)nodeCountInCurrLevel);
            }

            return result;
        }
    }
    
    // Time: O(N)
    // Space: O(N)
}