using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0103
{
    public IList<IList<int>> ZigzagLevelOrder_Ver1(TreeNode root)
    {
        var result = new List<IList<int>>();
        var depth = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var count = queue.Count;
            var list = new List<int>();

            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }

                list.Add(node.val);

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            if (depth % 2 == 1)
            {
                list.Reverse();
            }

            if (list.Count != 0)
            {
                result.Add(list);
            }
        }

        return result;
    }

    public IList<IList<int>> ZigzagLevelOrder_Ver2(TreeNode root)
    {
        var result = new List<IList<int>>();
        var left = true;
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            var array = stack.ToArray();
            stack.Clear();

            var list = new List<int>();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    continue;
                }

                list.Add(array[i].val);

                if (left)
                {
                    stack.Push(array[i].left);
                    stack.Push(array[i].right);
                }
                else
                {
                    stack.Push(array[i].right);
                    stack.Push(array[i].left);
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
    
    public IList<IList<int>> ZigzagLevelOrder_Ver3(TreeNode root)
    {
        var result = new List<IList<int>>();
        var depth = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var count = queue.Count;
            var list = new List<int>();

            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }

                if (depth % 2 == 0)
                {
                    list.Add(node.val);
                }
                else
                {
                    list.Insert(0, node.val);
                }

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            if (list.Count != 0)
            {
                result.Add(list);
            }
        }

        return result;
    }
}