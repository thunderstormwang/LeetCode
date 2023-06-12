namespace LeetCode.Solution0201_0300;

public class Solution0261
{
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public bool ValidTree_Ver1(int n, int[][] edges)
    {
        var queue = new Queue<int>();
        var adjacentList = new Dictionary<int, List<int>>();
        var nodeCount = 0;
        var visited = new int [n];

        for (var i = 0; i < n; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for (var i = 0; i < edges.Length; i++)
        {
            adjacentList[edges[i][0]].Add(edges[i][1]);
            adjacentList[edges[i][1]].Add(edges[i][0]);
        }

        queue.Enqueue(0);

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            visited[node] = 1;
            nodeCount++;

            for (var j = 0; j < adjacentList[node].Count; j++)
            {
                if (visited[adjacentList[node][j]] == 1)
                {
                    return false;
                }

                adjacentList[adjacentList[node][j]].Remove(node);
                queue.Enqueue(adjacentList[node][j]);
            }
        }

        return nodeCount == n;
    }

    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool ValidTree_Ver2(int n, int[][] edges)
    {
        var adjacentList = new Dictionary<int, List<int>>();
        var visited = new int [n];

        for (var i = 0; i < n; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for (var i = 0; i < edges.Length; i++)
        {
            adjacentList[edges[i][0]].Add(edges[i][1]);
            adjacentList[edges[i][1]].Add(edges[i][0]);
        }

        if (!DepthFirstSearch(0, -1, adjacentList, visited))
        {
            return false;
        }

        for (var i = 0; i < n; i++)
        {
            if (visited[i] == 0)
            {
                return false;
            }
        }

        return true;
    }

    private bool DepthFirstSearch(int node, int preNode, Dictionary<int, List<int>> adjacentList, int[] visited)
    {
        if (visited[node] == 1)
        {
            return false;
        }

        visited[node] = 1;

        for (var i = 0; i < adjacentList[node].Count; i++)
        {
            if (adjacentList[node][i] == preNode)
            {
                continue;
            }

            if (!DepthFirstSearch(adjacentList[node][i], node, adjacentList, visited))
            {
                return false;
            }
        }

        return true;
    }
}