using LeetCode.Models;

namespace LeetCode.Solution0501_0700;

public class Solution0662
{
    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int WidthOfBinaryTree_Ver1(TreeNode root)
    {
        return PreorderSearch(root, 0, 0, new List<int>());
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int WidthOfBinaryTree_Ver2(TreeNode root)
    {
        var result = 0;
        var queue = new Queue<(TreeNode Node, int Id)>();
        queue.Enqueue((root, 0));

        while(queue.Count != 0)
        {
            var count = queue.Count;
            var left = -1;
            for(var i = 0; i < count; i++)
            {
                var element = queue.Dequeue();
                if(element.Node == null)
                {
                    continue;
                }

                if(left == -1)
                {
                    left = element.Id;
                }

                result = Math.Max(result, element.Id - left + 1);
                queue.Enqueue((element.Node.left, 2 * element.Id));
                queue.Enqueue((element.Node.right, 2 * element.Id + 1));
            }
        }

        return result;  
    }

    private int PreorderSearch(TreeNode root, int depth, int id, List<int> list)
    {
        if (root == null)
        {
            return 0;
        }

        if (list.Count - 1 < depth)
        {
            list.Add(id);
        }

        var currWidth = id - list[depth] + 1;
        var left = PreorderSearch(root.left, depth + 1, 2 * id, list);
        var right = PreorderSearch(root.right, depth + 1, 2 * id + 1, list);

        return Math.Max(currWidth, Math.Max(left, right));
    }
}