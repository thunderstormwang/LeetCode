using System.Linq;

namespace LeetCode.Tests
{
    public class Utility
    {
        public static TreeNode BuildTree(TreeNode root, int?[] input, int i)
        {
            if (i < input.Length && input[i] != null)
            {
                root = new TreeNode(input[i].Value);

                root.left = BuildTree(root.left, input, 2 * i + 1);
                root.right = BuildTree(root.right, input, 2 * i + 2);
            }
            return root;
        }

        public static int?[] Parse2Array(string array1)
        {
            return array1.Split(',')
                        .Select(x => x.TryParse())
                        .ToList()
                        .ToArray();
        }
    }
}