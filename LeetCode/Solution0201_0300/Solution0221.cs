namespace LeetCode.Solution0201_0300;

public class Solution0221
{
    public int MaximalSquare(char[][] matrix)
    {
        var result = 0;
        var dp = new int [matrix.Length][];
        for (var i = 0; i < matrix.Length; i++)
        {
            dp[i] = new int [matrix[i].Length];
        }

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                dp[i][j] = matrix[i][j] == '1' ? 1 : 0;
            }
        }

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (dp[i][j] == 0)
                {
                    continue;
                }

                if (i - 1 >= 0 && j - 1 >= 0)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;
                }

                result = Math.Max(result, dp[i][j] * dp[i][j]);
            }
        }

        return result;
    }
}