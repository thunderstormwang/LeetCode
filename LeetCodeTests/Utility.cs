using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    public class Utility
    {
        public static TreeNode BuildTree(int?[] input,
            int i)
        {
            if (i >= input.Length || input[i] == null)
            {
                return null;
            }

            var root = new TreeNode(input[i].Value);

            root.left = BuildTree(input,
                2 * i + 1);
            root.right = BuildTree(input,
                2 * i + 2);

            return root;
        }

        public static TreeNodeV2 BuildTreeV2(int?[] input,
            int i)
        {
            if (i >= input.Length || input[i] == null)
            {
                return null;
            }

            var root = new TreeNodeV2(input[i].Value);

            root.left = BuildTreeV2(input,
                2 * i + 1);
            root.right = BuildTreeV2(input,
                2 * i + 2);

            return root;
        }

        public static string GetNodeString(TreeNodeV2 root)
        {
            var queue = new Queue<TreeNodeV2>();
            var nodeStr = new List<string>();
            var firstNodeFromLeft = new List<TreeNodeV2>();

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                var node = queue.Dequeue();
                firstNodeFromLeft.Add(node);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                nodeNumberInCurrLevel--;

                while (nodeNumberInCurrLevel > 0)
                {
                    node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    nodeNumberInCurrLevel--;
                }
            }

            foreach (var item in firstNodeFromLeft)
            {
                var node = item;
                while (node != null)
                {
                    nodeStr.Add(node.val.ToString());
                    node = node.next;
                }

                nodeStr.Add("#");
            }

            return string.Join(",",
                nodeStr);
        }

        public static ListNode BuildListNode(int[] array)
        {
            var dummyNode = new ListNode(0);
            var node = dummyNode;

            foreach (var item in array)
            {
                var temp = new ListNode(item);
                node.next = temp;
                node = temp;
            }

            return dummyNode.next;
        }

        public static Node Build_N_ary_Tree(int?[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            var queue = new Queue<Node>();
            var root = new Node(array[0].Value);

            queue.Enqueue(root);
            Node curr = null;
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    curr = queue.Dequeue();
                    continue;
                }

                var child = new Node(array[i].Value);
                if (curr.children == null)
                {
                    curr.children = new List<Node>();
                }

                curr.children.Add(child);
                queue.Enqueue(child);
            }

            return root;
        }

        public static bool CheckListNode(ListNode list1,
            ListNode list2)
        {
            while (list1 != null || list2 != null)
            {
                var x = list1 != null ? list1.val : -99;
                var y = list2 != null ? list2.val : -99;

                if (x != y)
                {
                    return false;
                }

                list1 = list1 != null ? list1.next : list1;
                list2 = list2 != null ? list2.next : list2;
            }

            return true;
        }
    }
}