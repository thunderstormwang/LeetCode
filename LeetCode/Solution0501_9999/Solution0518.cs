using System.Diagnostics;

namespace LeetCode.Solution0501_9999;

public class Solution0518
{
    public int Change(int amount, int[] coins)
    {
        var dp = new int[coins.Length + 1][];
        for (var i = 0; i < coins.Length + 1; i++)
        {
            dp[i] = new int[amount + 1];
        }

        for (var i = 0; i < coins.Length + 1; i++)
        {
            dp[i][0] = 1;
        }

        for (var i = 0; i < coins.Length; i++)
        {
            for (var j = coins[i]; j <= amount; j++)
            {
                Debug.WriteLine($"{coins[i]}, dp[{i+1}][{j}] = dp[{i}][{j}] + dp[{i + 1}][{j - coins[i]}] = {dp[i][j] + dp[i + 1][j - coins[i]]}");
                dp[i + 1][j] = dp[i][j] + dp[i + 1][j - coins[i]];
            }
        }

        return dp[coins.Length][amount];
    }
}