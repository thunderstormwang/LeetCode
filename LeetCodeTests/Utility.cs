using LeetCode.Models;

namespace LeetCodeTests;

public class Utility
{
    public static TreeNode BuildTree(int?[] input, int i)
    {
        if (i >= input.Length || input[i] == null)
        {
            return null;
        }

        var root = new TreeNode(input[i].Value);

        root.left = BuildTree(input, 2 * i + 1);
        root.right = BuildTree(input, 2 * i + 2);

        return root;
    }

    public static TreeNodeV2 BuildTreeV2(int?[] input, int i)
    {
        if (i >= input.Length || input[i] == null)
        {
            return null;
        }

        var root = new TreeNodeV2(input[i].Value);

        root.left = BuildTreeV2(input, 2 * i + 1);
        root.right = BuildTreeV2(input, 2 * i + 2);

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

        return string.Join(",", nodeStr);
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
        
    public static ListNode BuildListNode(int[] input, int pos)
    {
        ListNode result = null;
        ListNode tail = null;

        for (var i = input.Length - 1; i >= 0; i--)
        {
            var temp = result;
            result = new ListNode(input[i]);
            result.next = temp;

            if (tail == null)
            {
                tail = result;
            }

            if (i == pos)
            {
                tail.next = result;
            }
        }

        return result;
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
            if (curr != null && curr.children == null)
            {
                curr.children = new List<Node>();
            }

            curr?.children.Add(child);
            queue.Enqueue(child);
        }

        return root;
    }

    public static bool CheckLinkedList(ListNode list1, ListNode list2)
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

    public static bool CheckBinaryTree(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
        {
            return true;
        }

        if (root1 == null || root2 == null)
        {
            return false;
        }

        return root1.val == root2.val
               && CheckBinaryTree(root1.left, root2.left)
               && CheckBinaryTree(root1.right, root2.right);
    }

    public static GraphNode BuildGraphNode(int[][] adjList)
    {
        if (adjList == null)
        {
            return null;
        }
            
        var dict = new Dictionary<int, GraphNode>();

        for (var i = 0; i < adjList.Length; i++)
        {
            var value = i + 1;

            if (!dict.ContainsKey(value))
            {
                GraphNode temp = new GraphNode(value);
                dict.Add(value, temp);
            }

            GraphNode node = dict[value];

            foreach (var item in adjList[i])
            {
                if (!dict.ContainsKey(item))
                {
                    GraphNode temp = new GraphNode(item);
                    dict.Add(item, temp);
                }

                node.neighbors.Add(dict[item]);
            }
        }

        return dict[1];
    }

    public static bool CheckGraphNode(GraphNode node1, GraphNode node2, Dictionary<int, GraphNode> dict1, Dictionary<int, GraphNode> dict2)
    {
        if (node1 == null && node2 == null)
        {
            return true;
        }

        if (node1 == null || node2 == null)
        {
            return false;
        }

        if (node1.neighbors == null && node2.neighbors == null)
        {
            return true;
        }

        if (dict1.ContainsKey(node1.val) && dict2.ContainsKey(node2.val))
        {
            return true;
        }

        if (dict1.ContainsKey(node1.val) && !dict2.ContainsKey(node2.val)
            || (!dict1.ContainsKey(node1.val) && dict2.ContainsKey(node2.val)))
        {
            return false;
        }

        if ((node1.val != node2.val)
            || (node1.neighbors == null && node2.neighbors != null)
            || (node1.neighbors != null && node2.neighbors == null)
            || (node1.neighbors.Count != node2.neighbors.Count))
        {
            return false;
        }
            
        dict1.Add(node1.val, node1);
        dict2.Add(node2.val, node2);

        for (var i = 0; i < node1.neighbors.Count; i++)
        {
            if (!CheckGraphNode(node1.neighbors[i], node2.neighbors[i], dict1, dict2))
            {
                return false;
            }
        }

        return true;
    }
}