using System.Linq;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
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
                        .ToArray();
        }
        
        public static ListNode BuildListNode(int [] array)
        {
            if (array.Length == 0)
            {
                return null;
            }
            
            var head = new ListNode(array[0]);
            var node = head;

            for (int i = 1; i < array.Length; i++)
            {
                var temp = new ListNode(array[i]);
                node.next = temp;
                node = temp;
            }

            return head;
        }
    }
}