using System.Text;
using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0297
{
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root)
    {
        var sBuilder = new StringBuilder();

        Serialize_DFS(root, sBuilder);
        sBuilder.Remove(sBuilder.Length - 1, 1);

        return sBuilder.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data)
    {
        var strs = data.Split(',').ToArray();
        var index = 0;

        return Deserialize_DFS(strs, ref index);
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
}