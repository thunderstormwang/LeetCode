using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0117
    {
        public TreeNodeV2 Connect(TreeNodeV2 root)
        {
            var queue = new Queue<TreeNodeV2>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                TreeNodeV2 pre = null;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node == null)
                    {
                        nodeNumberInCurrLevel--;
                        continue;
                    }

                    if (pre != null)
                    {
                        pre.next = node;
                    }

                    pre = node;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                    nodeNumberInCurrLevel--;
                }
            }

            return root;
        }
    }
}