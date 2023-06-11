namespace LeetCode.Solution0501_9999;

public class Solution1730
{
    public int GetFood(char[][] grid)
    {
        var queue = new Queue<int[]>();
        var hasFood = false;
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '*')
                {
                    queue.Enqueue(new[] { i, j });
                }

                if (grid[i][j] == '#')
                {
                    hasFood = true;
                }
            }
        }

        if (!hasFood)
        {
            return -1;
        }

        var result = 0;

        while (queue.Count != 0)
        {
            var count = queue.Count;
            for (var cnt = 0; cnt < count; cnt++)
            {
                var cell = queue.Dequeue();

                for (var i = 0; i < directions.Length; i++)
                {
                    var newCell = new int[] { cell[0] + directions[i][0], cell[1] + directions[i][1] };
                    if (newCell[0] < 0 || newCell[0] >= grid.Length
                                       || newCell[1] < 0 || newCell[1] >= grid[newCell[0]].Length
                                       || grid[newCell[0]][newCell[1]] == 'X' || grid[newCell[0]][newCell[1]] == '*')
                    {
                        continue;
                    }

                    if (grid[newCell[0]][newCell[1]] == '#')
                    {
                        return result + 1;
                    }

                    grid[newCell[0]][newCell[1]] = '*';
                    queue.Enqueue(newCell);
                }
            }

            result++;
        }

        return -1;
    }
}