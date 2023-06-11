namespace LeetCode.Solution0301_0500;

public class Solution0417
{
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public IList<IList<int>> PacificAtlantic_Ver1(int[][] heights)
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
        var result = new List<IList<int>>();

        for (var i = 0; i < heights.Length; i++)
        {
            pacific[i] = new int [heights[i].Length];
            atlantic[i] = new int [heights[i].Length];
        }

        var pacificQueue = new Queue<int[]>();
        var atlanticQueue = new Queue<int[]>();
        for (var i = 0; i < heights.Length; i++)
        {
            pacific[i][0] = 1;
            pacificQueue.Enqueue(new int[] { i, 0 });

            atlantic[i][heights[i].Length - 1] = 1;
            atlanticQueue.Enqueue(new int[] { i, heights[i].Length - 1 });
        }

        for (var j = 0; j < heights[0].Length; j++)
        {
            pacific[0][j] = 1;
            pacificQueue.Enqueue(new int[] { 0, j });

            atlantic[heights.Length - 1][j] = 1;
            atlanticQueue.Enqueue(new int[] { heights.Length - 1, j });
        }

        BreadthFirstSearch(heights, pacificQueue, pacific, directions);
        BreadthFirstSearch(heights, atlanticQueue, atlantic, directions);

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

    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public IList<IList<int>> PacificAtlantic_Ver2(int[][] heights)
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
        var result = new List<IList<int>>();

        for (var i = 0; i < heights.Length; i++)
        {
            pacific[i] = new int [heights[i].Length];
            atlantic[i] = new int [heights[i].Length];
        }

        for (var i = 0; i < heights.Length; i++)
        {
            DepthFirstSearch(i, 0, heights, pacific, directions, 0);
            DepthFirstSearch(i, heights[i].Length - 1, heights, atlantic, directions, 0);
        }

        for (var j = 0; j < heights[0].Length; j++)
        {
            DepthFirstSearch(0, j, heights, pacific, directions, 0);
            DepthFirstSearch(heights.Length - 1, j, heights, atlantic, directions, 0);
        }

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

    private void BreadthFirstSearch(int[][] heights, Queue<int[]> queue, int[][] flow, int[][] directions)
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

    private void DepthFirstSearch(int i, int j, int[][] heights, int[][] flow, int[][] directions, int lastHeight)
    {
        if (i < 0 || i >= heights.Length
                  || j < 0 || j >= heights[i].Length
                  || flow[i][j] == 1 || lastHeight > heights[i][j])
        {
            return;
        }

        flow[i][j] = 1;

        for (var cnt = 0; cnt < directions.Length; cnt++)
        {
            var newLand = new int[] { i + directions[cnt][0], j + directions[cnt][1] };
            DepthFirstSearch(newLand[0], newLand[1], heights, flow, directions, heights[i][j]);
        }
    }
}