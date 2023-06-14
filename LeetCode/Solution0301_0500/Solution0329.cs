namespace LeetCode.Solution0301_0500;

public class Solution0329
{
    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int LongestIncreasingPath_Ver1(int[][] matrix)
    {
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        var result = 0;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                result = Math.Max(DepthFirstSearch_Ver1(new int[] { i, j }, matrix, 0, -1, directions), result);
            }
        }

        return result;
    }

    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int LongestIncreasingPath_Ver2(int[][] matrix)
    {
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        var record = new int [matrix.Length][];
        for (var i = 0; i < matrix.Length; i++)
        {
            record[i] = new int [matrix[i].Length];
        }

        var result = 0;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                DepthFirstSearch_Ver2(new int[] { i, j }, matrix, directions, record);
                result = Math.Max(record[i][j], result);
            }
        }

        return result;
    }

    private int DepthFirstSearch_Ver1(int[] curr, int[][] matrix, int step, int preValue, int[][] directions)
    {
        if (curr[0] < 0 || curr[0] >= matrix.Length
                        || curr[1] < 0 || curr[1] >= matrix[curr[0]].Length
                        || preValue >= matrix[curr[0]][curr[1]])
        {
            return step;
        }

        var result = 0;

        for (var i = 0; i < directions.Length; i++)
        {
            var next = new int[] { curr[0] + directions[i][0], curr[1] + directions[i][1] };
            result = Math.Max(DepthFirstSearch_Ver1(next, matrix, step + 1, matrix[curr[0]][curr[1]], directions), result);
        }

        return result;
    }

    private void DepthFirstSearch_Ver2(int[] curr, int[][] matrix, int[][] directions, int[][] record)
    {
        if (record[curr[0]][curr[1]] != 0)
        {
            return;
        }

        var result = 1;

        for (var i = 0; i < directions.Length; i++)
        {
            var next = new int[] { curr[0] + directions[i][0], curr[1] + directions[i][1] };
            if (next[0] < 0 || next[0] >= matrix.Length || next[1] < 0 || next[1] >= matrix[next[0]].Length
                || matrix[curr[0]][curr[1]] <= matrix[next[0]][next[1]])
            {
                continue;
            }

            DepthFirstSearch_Ver2(next, matrix, directions, record);
            result = Math.Max(1 + record[next[0]][next[1]], result);
        }

        record[curr[0]][curr[1]] = result;
    }
}