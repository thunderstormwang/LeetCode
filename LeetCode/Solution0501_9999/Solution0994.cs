namespace LeetCode.Solution0501_9999;

public class Solution0994
{
    public int OrangesRotting(int[][] grid)
    {
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };

        var queue = new Queue<int[]>();
        var freshOrange = 0;
        var minute = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue(new int[] { i, j });
                }

                if (grid[i][j] == 1)
                {
                    freshOrange++;
                }
            }
        }

        while (queue.Count != 0 && freshOrange > 0)
        {
            var count = queue.Count;

            for (var cnt = 0; cnt < count; cnt++)
            {
                var rotten = queue.Dequeue();

                for (var i = 0; i < directions.Length; i++)
                {
                    var row = rotten[0] + directions[i][0];
                    var column = rotten[1] + directions[i][1];

                    if (row < 0 || row >= grid.Length || column < 0 || column >= grid[row].Length || grid[row][column] != 1)
                    {
                        continue;
                    }
                    
                    grid[row][column] = 2;
                    freshOrange--;
                    queue.Enqueue(new int[] { row, column });
                }
            }

            minute++;
        }

        return freshOrange == 0 ? minute : -1;
    }
}