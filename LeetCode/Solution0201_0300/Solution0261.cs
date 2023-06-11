namespace LeetCode.Solution0201_0300;

public class Solution0261
{
    public bool ValidTree(int n, int[][] edges)
    {
        var queue = new Queue<int>();
        var inDegree = new int [n];
        var adjacentList = new Dictionary<int, List<int>>();
        var nodeCount = 0;
        var visited = new int [n];

        for(var i = 0; i < n; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for(var i = 0; i < edges.Length; i++)
        {
            adjacentList[edges[i][0]].Add(edges[i][1]);
            adjacentList[edges[i][1]].Add(edges[i][0]);
            inDegree[edges[i][0]]++;
            inDegree[edges[i][1]]++;
        }
        
        for()

        while(queue.Count != 0)
        {
            var i = queue.Dequeue();
            nodeCount++;

            for(var j = 0; j < adjacentList[i].Count; j++)
            {
                inDegree[adjacentList[i][j]]--;
                adjacentList[adjacentList[i][j]].Remove(i);
                if(inDegree[adjacentList[i][j]] == 0)
                {
                    queue.Enqueue(adjacentList[i][j]);
                }
            }
        }
        
        return nodeCount == n;
    }
}