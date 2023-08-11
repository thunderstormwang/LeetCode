namespace LeetCode.Solution0051_0100;

public class Solution0062
{
    public int UniquePaths_Ver1(int m, int n)
    {
        var dp = new int [m][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int [n];
            dp[i][0] = 1;
        }

        for (var j = 0; j < n; j++)
        {
            dp[0][j] = 1;
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
            }
        }

        return dp[m - 1][n - 1];
    }

    public int UniquePaths_Ver2(int m, int n)
    {
        var allHoles = m - 1 + n - 1;
        var selectedHoles = m <= n ? m - 1 : n - 1;

        var result = 1L;

        for (var i = 1; i <= selectedHoles; i++)
        {
            result *= (allHoles - (i - 1));
            result /= i;
        }

        return (int)result;
    }
}