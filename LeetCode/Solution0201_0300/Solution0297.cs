using System.Text;
using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0297
{
    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    /// <remarks>Encodes a tree to a single string.</remarks>
    public string Serialize_Ver1(TreeNode root)
    {
        var sBuilder = new StringBuilder();

        Serialize_DFS(root, sBuilder);
        sBuilder.Remove(sBuilder.Length - 1, 1);

        return sBuilder.ToString();
    }

    /// <summary>
    /// DFS Recursive
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    /// <remarks>Decodes your encoded data to tree</remarks>
    public TreeNode Deserialize_Ver1(string data)
    {
        var strs = data.Split(',').ToArray();
        var index = 0;

        return Deserialize_DFS(strs, ref index);
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    /// <remarks>Encodes a tree to a single string.</remarks>
    public string Serialize_Ver2(TreeNode root)
    {
        var sBuilder = new StringBuilder();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();

            if (node == null)
            {
                sBuilder.Append("#,");
                continue;
            }

            sBuilder.Append(node.val.ToString() + ',');

            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        sBuilder.Remove(sBuilder.Length - 1, 1);

        return sBuilder.ToString();
    }

    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    /// <remarks>Decodes your encoded data to tree</remarks>
    public TreeNode Deserialize_Ver2(string data)
    {
        var strs = data.Split(',');
        var queue = new Queue<TreeNode>();
        int index = 0;

        var temp = strs[index];
        if (temp == "#")
        {
            return null;
        }

        var root = new TreeNode(int.Parse(temp));
        queue.Enqueue(root);
        index++;

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();

            temp = strs[index];
            if (temp != "#")
            {
                var child = new TreeNode(int.Parse(temp));
                node.left = child;
                queue.Enqueue(child);
            }

            index++;

            temp = strs[index];
            if (temp != "#")
            {
                var child = new TreeNode(int.Parse(temp));
                node.right = child;
                queue.Enqueue(child);
            }

            index++;
        }

        return root;
    }

    private void Serialize_DFS(TreeNode root, StringBuilder sBuilder)
    {
        if (root == null)
        {
            sBuilder.Append("#,");
            return;
        }

        sBuilder.Append(root.val.ToString() + ',');

        Serialize_DFS(root.left, sBuilder);
        Serialize_DFS(root.right, sBuilder);
    }

    private TreeNode Deserialize_DFS(string[] strs, ref int index)
    {
        if (index >= strs.Length)
        {
            return null;
        }

        if (strs[index] == "#")
        {
            index++;
            return null;
        }

        var root = new TreeNode(int.Parse(strs[index]));
        index++;

        root.left = Deserialize_DFS(strs, ref index);
        root.right = Deserialize_DFS(strs, ref index);

        return root;
    }
}