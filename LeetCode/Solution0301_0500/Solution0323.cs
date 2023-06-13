namespace LeetCode.Solution0301_0500;

public class Solution0323
{
    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int CountComponents_Ver1(int n, int[][] edges)
    {
        var adjacentList = new Dictionary<int, List<int>>();
        var visited = new int[n];
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for (var i = 0; i < edges.Length; i++)
        {
            adjacentList[edges[i][0]].Add(edges[i][1]);
            adjacentList[edges[i][1]].Add(edges[i][0]);
        }

        for (var i = 0; i < n; i++)
        {
            if (visited[i] != 0)
            {
                continue;
            }
            
            DepthFirstSearch(i, adjacentList, visited);
            result++;
        }

        return result;
    }

    public int CountComponents_Ver2(int n, int[][] edges)
    {
        var adjacentList = new Dictionary<int, List<int>>();
        var queue = new Queue<int>();
        var visited = new int[n];
        var result = 0;
        
        for (var i = 0; i < n; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for (var i = 0; i < edges.Length; i++)
        {
            adjacentList[edges[i][0]].Add(edges[i][1]);
            adjacentList[edges[i][1]].Add(edges[i][0]);
        }

        for (var i = 0; i < n; i++)
        {
            if (visited[i] == 1)
            {
                continue;
            }
            
            queue.Enqueue(i);
            while (queue.Count != 0)
            {
                var count = queue.Count;
                for (var cnt = 0; cnt < count; cnt++)
                {
                    var node = queue.Dequeue();
                    visited[node] = 1;

                    for (var j = 0; j < adjacentList[node].Count; j++)
                    {
                        if (visited[adjacentList[node][j]] == 1)
                        {
                            continue;
                        }
                        
                        queue.Enqueue(adjacentList[node][j]);
                    }
                }
            }

            result++;
        }

        return result;
    }

    /// <summary>
    /// Union Find
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int CountComponents_Ver3(int n, int[][] edges)
    {
        var parent = new Dictionary<int, int>();
        var result = n;

        for (var i = 0; i < n; i++)
        {
            parent.Add(i, i);
        }

        for (var i = 0; i < edges.Length; i++)
        {
            var node0Parent = FindParent(parent, edges[i][0]);
            var node1Parent = FindParent(parent, edges[i][1]);
            if (node0Parent != node1Parent)
            {
                parent[node0Parent] = node1Parent;
                result--;
            }
        }

        return result;
    }

    private void DepthFirstSearch(int node, Dictionary<int, List<int>> adjacentList, int[] visited)
    {
        if (visited[node] == 1)
        {
            return;
        }

        visited[node] = 1;

        for (var i = 0; i < adjacentList[node].Count; i++)
        {
            if (visited[adjacentList[node][i]] == 1)
            {
                continue;
            }

            DepthFirstSearch(adjacentList[node][i], adjacentList, visited);
        }
    }

    private int FindParent(Dictionary<int, int> parent, int node)
    {
        while (parent[node] != node)
        {
            // 路徑壓縮
            parent[node] = parent[parent[node]];
            node = parent[node];
        }

        return node;
    }
}