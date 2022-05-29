namespace LeetCode.Solution0201_0500
{
    public class Solution0429
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<Node>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                var list = new List<int>();
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        list.Add(node.val);

                        if (node.children != null)
                        {
                            foreach (var item in node.children)
                            {
                                queue.Enqueue(item);
                            }
                        }
                    }

                    nodeNumberInCurrLevel--;
                }

                if (list.Count != 0)
                {
                    result.Add(list);
                }
            }

            return result;
        }
        
        // Time: O(N)
        // Space: O(N)
    }
}