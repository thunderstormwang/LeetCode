namespace LeetCode.Solution0051_0100;

public class Solution0063
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var dp = new int [obstacleGrid.Length][];
        for (var i = 0; i < obstacleGrid.Length; i++)
        {
            dp[i] = new int [obstacleGrid[0].Length];
        }

        dp[0][0] = obstacleGrid[0][0] == 1 ? 0 : 1;

        for (var i = 1; i < obstacleGrid.Length; i++)
        {
            dp[i][0] = obstacleGrid[i][0] == 1 ? 0 : dp[i - 1][0];
        }

        for (var j = 1; j < obstacleGrid[0].Length; j++)
        {
            dp[0][j] = obstacleGrid[0][j] == 1 ? 0 : dp[0][j - 1];
        }

        for (var i = 1; i < obstacleGrid.Length; i++)
        {
            for (var j = 1; j < obstacleGrid[0].Length; j++)
            {
                dp[i][j] = obstacleGrid[i][j] == 1 ? 0 : dp[i - 1][j] + dp[i][j - 1];
            }
        }

        return dp[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];
    }
}