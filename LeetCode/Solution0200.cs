namespace LeetCode
{
    public class Solution0200
    {
        private readonly int[] xAxis = new int [4] { 1, -1, 0, 0 };
        private readonly int[] yAxis = new int [4] { 0, 0, 1, -1 };

        public int NumIslands(char[][] grid)
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

            for (var index = 0; index < 4; index++)
            {
                DiscoverIsland(grid, visit, i + xAxis[index], j + yAxis[index]);
            }
        }
    }
}