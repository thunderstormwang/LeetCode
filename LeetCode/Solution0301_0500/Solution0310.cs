namespace LeetCode.Solution0301_0500;

public class Solution0310
{
    public IList<int> FindMinHeightTrees_Ver1(int n, int[][] edges)
    {
        var result = new List<int>();
        var minHeight = int.MaxValue;
        var adjacencyList = new Dictionary<int, List<int>>();

        if (n == 1)
        {
            return new List<int>() { 0 };
        }

        for (var i = 0; i < edges.Length; i++)
        {
            if (!adjacencyList.ContainsKey(edges[i][0]))
            {
                adjacencyList.Add(edges[i][0], new List<int>());
            }

            if (!adjacencyList.ContainsKey(edges[i][1]))
            {
                adjacencyList.Add(edges[i][1], new List<int>());
            }

            adjacencyList[edges[i][0]].Add(edges[i][1]);
            adjacencyList[edges[i][1]].Add(edges[i][0]);
        }

        for (var i = 0; i < n; i++)
        {
            var queue = new Queue<int>();
            var visited = new int [n];
            var depth = 0;
            var hasMoreHeight = false;

            queue.Enqueue(i);
            visited[i] = 1;

            while (queue.Count != 0)
            {
                if (depth > minHeight)
                {
                    hasMoreHeight = true;
                    break;
                }

                var count = queue.Count;
                var newElement = false;

                for (var cnt = 0; cnt < count; cnt++)
                {
                    var node = queue.Dequeue();

                    for (var j = 0; j < adjacencyList[node].Count; j++)
                    {
                        if (visited[adjacencyList[node][j]] == 1)
                        {
                            continue;
                        }

                        if (!newElement)
                        {
                            newElement = true;
                            depth++;
                        }

                        queue.Enqueue(adjacencyList[node][j]);
                        visited[adjacencyList[node][j]] = 1;
                    }
                }
            }

            if (hasMoreHeight)
            {
                continue;
            }

            if (depth == minHeight)
            {
                result.Add(i);
            }

            if (depth < minHeight)
            {
                result = new List<int>() { i };
                minHeight = depth;
            }
        }

        return result;
    }

    public IList<int> FindMinHeightTrees_Ver2(int n, int[][] edges)
    {
        var adjacencyList = new Dictionary<int, List<int>>();
        var queue = new Queue<int>();

        if (n == 1)
        {
            return new List<int>() { 0 };
        }

        for (var i = 0; i < edges.Length; i++)
        {
            if (!adjacencyList.ContainsKey(edges[i][0]))
            {
                adjacencyList.Add(edges[i][0], new List<int>());
            }

            if (!adjacencyList.ContainsKey(edges[i][1]))
            {
                adjacencyList.Add(edges[i][1], new List<int>());
            }

            adjacencyList[edges[i][0]].Add(edges[i][1]);
            adjacencyList[edges[i][1]].Add(edges[i][0]);
        }

        foreach (var item in adjacencyList)
        {
            if (item.Value.Count == 1)
            {
                queue.Enqueue(item.Key);
            }
        }

        var nodeCount = n;
        while (nodeCount > 2)
        {
            var queueCount = queue.Count;
            nodeCount -= queueCount;
            for (var cnt = 0; cnt < queueCount; cnt++)
            {
                var node = queue.Dequeue();

                for (var i = 0; i < adjacencyList[node].Count; i++)
                {
                    var adjNode = adjacencyList[node][i];
                    adjacencyList[adjNode].Remove(node);
                    if (adjacencyList[adjNode].Count == 1)
                    {
                        queue.Enqueue(adjNode);
                    }
                }
            }
            
        }

        return new List<int>(queue.ToArray());
    }
}