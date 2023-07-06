using LeetCode.Models;

namespace LeetCode.Solution0701_9999;

public class Solution0863
{
    public IList<int> DistanceK_Ver1(TreeNode root, TreeNode target, int k)
    {
        var result = new List<int>();
        var parentDict = new Dictionary<TreeNode, TreeNode>();
        var visited = new HashSet<TreeNode>();

        FindParent(root, null, parentDict);

        SearchNode_Ver1(target, parentDict, k, visited, result);

        return result;
    }

    public IList<int> DistanceK_Ver2(TreeNode root, TreeNode target, int k)
    {
        var result = new List<int>();
        var graph = new Dictionary<TreeNode, List<TreeNode>>();
        var visited = new HashSet<TreeNode>();
        var queue = new Queue<TreeNode>();

        BuildGraph(root, null, graph);

        queue.Enqueue(target);
        visited.Add(target);

        while (queue.Count != 0)
        {
            var count = queue.Count;

            if (k == 0)
            {
                for (var i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    result.Add(node.val);
                }

                break;
            }

            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();

                for (var j = 0; j < graph[node].Count; j++)
                {
                    if (visited.Contains(graph[node][j]))
                    {
                        continue;
                    }

                    queue.Enqueue(graph[node][j]);
                    visited.Add(graph[node][j]);
                }
            }

            k--;
        }

        return result;
    }

    public IList<int> DistanceK_Ver3(TreeNode root, TreeNode target, int k)
    {
        var result = new List<int>();

        FindDistance(root, target, k, result);

        return result;
    }

    private void FindParent(TreeNode root, TreeNode pre, Dictionary<TreeNode, TreeNode> parentDict)
    {
        if (root == null)
        {
            return;
        }

        parentDict.Add(root, pre);
        FindParent(root.left, root, parentDict);
        FindParent(root.right, root, parentDict);
    }

    private void SearchNode_Ver1(TreeNode target, Dictionary<TreeNode, TreeNode> parentDict, int k, HashSet<TreeNode> visited, IList<int> result)
    {
        if (target == null || visited.Contains(target))
        {
            return;
        }

        visited.Add(target);

        if (k == 0)
        {
            result.Add(target.val);
            return;
        }

        SearchNode_Ver1(parentDict[target], parentDict, k - 1, visited, result);
        SearchNode_Ver1(target.left, parentDict, k - 1, visited, result);
        SearchNode_Ver1(target.right, parentDict, k - 1, visited, result);
    }

    private void BuildGraph(TreeNode root, TreeNode pre, Dictionary<TreeNode, List<TreeNode>> graph)
    {
        if (root == null)
        {
            return;
        }

        if (!graph.ContainsKey(root))
        {
            graph.Add(root, new List<TreeNode>());
        }

        if (pre != null)
        {
            graph[root].Add(pre);
            graph[pre].Add(root);
        }

        BuildGraph(root.left, root, graph);
        BuildGraph(root.right, root, graph);
    }

    private int FindDistance(TreeNode root, TreeNode target, int k, List<int> result)
    {
        if (root == null)
        {
            return -1;
        }

        if (root == target)
        {
            SearchNode_Ver3(root, target, k, result);
            return 0;
        }

        var left = FindDistance(root.left, target, k, result);
        if (left != -1)
        {
            if (left + 1 == k)
            {
                result.Add(root.val);
            }
            else
            {
                SearchNode_Ver3(root.right, target, k - (left + 2), result);
            }

            return left + 1;
        }

        var right = FindDistance(root.right, target, k, result);
        if (right != -1)
        {
            if (right + 1 == k)
            {
                result.Add(root.val);
            }
            else
            {
                SearchNode_Ver3(root.left, target, k - (right + 2), result);
            }

            return right + 1;
        }

        return -1;
    }

    private void SearchNode_Ver3(TreeNode root, TreeNode target, int k, IList<int> result)
    {
        if (root == null || k < 0)
        {
            return;
        }

        if (k == 0)
        {
            result.Add(root.val);
            return;
        }

        SearchNode_Ver3(root.left, target, k - 1, result);
        SearchNode_Ver3(root.right, target, k - 1, result);
    }
}