using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0103
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        var left = true;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var array = queue.ToArray();
            queue.Clear();

            var list = new List<int>();
            for (var i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == null)
                {
                    continue;
                }

                list.Add(array[i].val);

                if (left)
                {
                    queue.Enqueue(array[i].left);
                    queue.Enqueue(array[i].right);
                }
                else
                {
                    queue.Enqueue(array[i].right);
                    queue.Enqueue(array[i].left);
                }
            }

            if (list.Count != 0)
            {
                result.Add(list);
            }

            left = !left;
        }

        return result;
    }
}