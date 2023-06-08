namespace LeetCode.Solution0301_0500;

public class Solution0417
{
    // BFS
    // DFS
    
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var pacific = new int [heights.Length][];
        var atlantic = new int [heights.Length][];
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        for (var i = 0; i < heights.Length; i++)
        {
            pacific[i] = new int [heights[i].Length];
            atlantic[i] = new int [heights[i].Length];
        }

        for (var i = 0; i < heights.Length; i++)
        {
            var queue = new Queue<int[]>();

            if (pacific[i][0] == 0)
            {
                pacific[i][0] = 1;
                queue.Enqueue(new int[] { i, 0 });
                BFS(heights, queue, pacific, directions);
            }

            if (atlantic[i][heights[i].Length - 1] == 0)
            {
                atlantic[i][heights[i].Length - 1] = 1;
                queue.Enqueue(new int[] { i, heights[i].Length - 1 });
                BFS(heights, queue, atlantic, directions);
            }
        }

        for (var j = 0; j < heights[0].Length; j++)
        {
            var queue = new Queue<int[]>();

            if (pacific[0][j] == 0)
            {
                pacific[0][j] = 1;
                queue.Enqueue(new int[] { 0, j });
                BFS(heights, queue, pacific, directions);
            }

            if (atlantic[heights.Length - 1][j] == 0)
            {
                atlantic[heights.Length - 1][j] = 1;
                queue.Enqueue(new int[] { heights.Length - 1, j });
                BFS(heights, queue, atlantic, directions);
            }
        }

        var result = new List<IList<int>>();

        for (var i = 0; i < heights.Length; i++)
        {
            for (var j = 0; j < heights[i].Length; j++)
            {
                if (pacific[i][j] == 1 && atlantic[i][j] == 1)
                {
                    result.Add(new List<int>() { i, j });
                }
            }
        }

        return result;
    }

    private void BFS(int[][] heights, Queue<int[]> queue, int[][] flow, int[][] directions)
    {
        while (queue.Count != 0)
        {
            var land = queue.Dequeue();

            for (var dir = 0; dir < directions.Length; dir++)
            {
                var newLand = new int[] { land[0] + directions[dir][0], land[1] + directions[dir][1] };

                if (newLand[0] < 0 || newLand[0] >= heights.Length
                                   || newLand[1] < 0 || newLand[1] >= heights[0].Length
                                   || flow[newLand[0]][newLand[1]] == 1 || heights[land[0]][land[1]] > heights[newLand[0]][newLand[1]])
                {
                    continue;
                }

                flow[newLand[0]][newLand[1]] = 1;
                queue.Enqueue(newLand);
            }
        }
    }
}