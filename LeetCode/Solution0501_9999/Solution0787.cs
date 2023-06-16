using System.Data;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace LeetCode.Solution0501_9999;

public class Solution0787
{
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="n"></param>
    /// <param name="flights"></param>
    /// <param name="src"></param>
    /// <param name="dst"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int FindCheapestPrice_Ver1(int n, int[][] flights, int src, int dst, int k)
    {
        var dist = new int [n];
        var step = 0;
        var flightPrices = new Dictionary<int, Dictionary<int, int>>();
        var queue = new Queue<int[]>();

        for (var i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue;
            flightPrices.Add(i, new Dictionary<int, int>());
        }

        for (var i = 0; i < flights.Length; i++)
        {
            flightPrices[flights[i][0]].Add(flights[i][1], flights[i][2]);
        }

        queue.Enqueue(new int[] { src, 0 });

        while (queue.Count != 0 && step <= k)
        {
            var count = queue.Count;

            for (var cnt = 0; cnt < count; cnt++)
            {
                var node = queue.Dequeue();

                foreach (var item in flightPrices[node[0]])
                {
                    var nextNode = item.Key;
                    var price = item.Value;
                    var accumulatePrice = node[1];
                    if (accumulatePrice + price > dist[nextNode])
                    {
                        continue;
                    }

                    dist[nextNode] = accumulatePrice + price;
                    queue.Enqueue(new int[] { nextNode, dist[nextNode] });
                }
            }

            step++;
        }

        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }

    public int FindCheapestPrice_Ver2(int n, int[][] flights, int src, int dst, int k)
    {
        var dist = new int [k + 2][];

        for (var i = 0; i < k + 2; i++)
        {
            dist[i] = new int [n];

            for (var j = 0; j < n; j++)
            {
                dist[i][j] = int.MaxValue;
            }

            dist[i][src] = 0;
        }

        for (var cnt = 1; cnt < k + 2; cnt++)
        {
            for (var i = 0; i < flights.Length; i++)
            {
                if (dist[cnt - 1][flights[i][0]] == int.MaxValue)
                {
                    continue;
                }

                dist[cnt][flights[i][1]] = Math.Min(dist[cnt][flights[i][1]], dist[cnt - 1][flights[i][0]] + flights[i][2]);
            }
            
            Debug.WriteLine($"cnt = {cnt}, {string.Join(", ", dist[cnt])}");
        }

        return dist[k + 1][dst] == int.MaxValue ? -1 : dist[k + 1][dst];
    }
    
    public int FindCheapestPrice_Ver3(int n, int[][] flights, int src, int dst, int k)
    {
        var dist = new int [n];

        for (var i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue;
        }        
        dist[src] = 0;

        for (var cnt = 1; cnt < k + 2; cnt++)
        {
            var temp = dist.ToArray();
            for (var i = 0; i < flights.Length; i++)
            {
                if (dist[flights[i][0]] == int.MaxValue)
                {
                    continue;
                }

                temp[flights[i][1]] = Math.Min(temp[flights[i][1]], dist[flights[i][0]] + flights[i][2]);
            }

            dist = temp;
            
            Debug.WriteLine($"cnt = {cnt}, {string.Join(", ", dist)}");
        }

        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
}