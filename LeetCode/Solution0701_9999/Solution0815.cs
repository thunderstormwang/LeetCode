namespace LeetCode.Solution0701_9999;

public class Solution0815
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var busStopRoutes = new Dictionary<int, List<int>>();
        var queue = new Queue<int>();
        var visited = new int [routes.Length];
        var result = 0;
        
        for (var i = 0; i < routes.Length; i++)
        {
            for (var j = 0; j < routes[i].Length; j++)
            {
                if (!busStopRoutes.ContainsKey(routes[i][j]))
                {
                    busStopRoutes.Add(routes[i][j], new List<int>());
                }

                busStopRoutes[routes[i][j]].Add(i);
            }
        }

        queue.Enqueue(source);

        while (queue.Count != 0)
        {
            var count = queue.Count;

            for (var cnt = 0; cnt < count; cnt++)
            {
                var busStop = queue.Dequeue();
                if (busStop == target)
                {
                    return result;
                }

                for (var i = 0; i < busStopRoutes[busStop].Count; i++)
                {
                    var route = busStopRoutes[busStop][i];
                    if (visited[route] == 1)
                    {
                        continue;
                    }

                    visited[route] = 1;
                    for (var j = 0; j < routes[route].Length; j++)
                    {
                        if (routes[route][j] == busStop)
                        {
                            continue;
                        }

                        queue.Enqueue(routes[route][j]);
                    }
                }
            }

            result++;
        }

        return -1;
    }
}