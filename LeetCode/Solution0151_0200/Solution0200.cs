namespace LeetCode.Solution0151_0200;

public class Solution0200
{
    private readonly int[][] directions = new int [4][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    public int NumIslands_DFS(char[][] grid)
    {
        var result = 0;
        var visit = new bool [grid.Length][];
        for (var i = 0; i < grid.Length; i++)
        {
            visit[i] = new bool[grid[i].Length];
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != '1' || visit[i][j])
                {
                    continue;
                }

                DiscoverIsland(grid, visit, i, j);
                result++;
            }
        }

        return result;
    }

    public object NumIslands_BFS(char[][] grid)
    {
        var result = 0;
        var visit = new bool [grid.Length][];
        for (var i = 0; i < grid.Length; i++)
        {
            visit[i] = new bool[grid[i].Length];
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != '1' || visit[i][j])
                {
                    continue;
                }

                var queue = new Queue<int[]>();
                queue.Enqueue(new int[] { i, j });

                while (queue.Count != 0)
                {
                    var pos = queue.Dequeue();

                    if (pos[0] < 0 || pos[0] >= grid.Length
                                   || pos[1] < 0 || pos[1] >= grid[0].Length
                                   || grid[pos[0]][pos[1]] == '0' || visit[pos[0]][pos[1]])
                    {
                        continue;
                    }

                    visit[pos[0]][pos[1]] = true;

                    for (var k = 0; k < directions.Length; k++)
                    {
                        queue.Enqueue(new int[] { pos[0] + directions[k][0], pos[1] + directions[k][1] });
                    }
                }

                result++;
            }
        }

        return result;
    }

    private void DiscoverIsland(char[][] grid, bool[][] visit, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length)
        {
            return;
        }

        if (grid[i][j] == '0' || visit[i][j])
        {
            return;
        }

        visit[i][j] = true;

        for (var index = 0; index < directions.Length; index++)
        {
            DiscoverIsland(grid, visit, i + directions[index][0], j + directions[index][1]);
        }
    }
}