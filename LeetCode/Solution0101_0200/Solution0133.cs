using LeetCode.Models;

namespace LeetCode.Solution0101_0200;

public class Solution0133
{
    public GraphNode CloneGraph_DFS(GraphNode node)
    {
        if (node == null)
        {
            return null;
        }

        var dict = new Dictionary<int, GraphNode>();

        var result = Recursive(node, dict);
        return result;
    }

    public GraphNode CloneGraph_BFS(GraphNode node)
    {
        if (node == null)
        {
            return null;
        }

        var queue = new Queue<GraphNode>();
        var dict = new Dictionary<int, GraphNode>();

        var cloneNode = new GraphNode(node.val);
        dict.Add(cloneNode.val, cloneNode);
        queue.Enqueue(node);

        while (queue.Count != 0)
        {
            var targetNode = queue.Dequeue();
            for (var i = 0; i < targetNode.neighbors.Count; i++)
            {
                if (!dict.ContainsKey(targetNode.neighbors[i].val))
                {
                    var childNode = new GraphNode(targetNode.neighbors[i].val);
                    dict.Add(targetNode.neighbors[i].val, childNode);
                    queue.Enqueue(targetNode.neighbors[i]);
                }

                dict[targetNode.val].neighbors.Add(dict[targetNode.neighbors[i].val]);
            }
        }


        return cloneNode;
    }

    private GraphNode Recursive(GraphNode node, Dictionary<int, GraphNode> dict)
    {
        GraphNode cloneNode = null;
        if (dict.ContainsKey(node.val))
        {
            cloneNode = dict[node.val];
            return cloneNode;
        }

        cloneNode = new GraphNode(node.val);
        dict.Add(node.val, cloneNode);

        for (var i = 0; i < node.neighbors.Count; i++)
        {
            var childNode = Recursive(node.neighbors[i], dict);
            cloneNode.neighbors.Add(childNode);
        }

        return cloneNode;
    }
}