using System.Diagnostics;

namespace LeetCode.Solution0501_9999;

public class Solution0518
{
    public int Change_Ver1(int amount, int[] coins)
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
            for (var j = 1; j <= amount; j++)
            {
                if (j < coins[i])
                {
                    dp[i + 1][j] += dp[i][j];
                }
                else
                {
                    dp[i + 1][j] += dp[i][j] + dp[i + 1][j - coins[i]];
                }
            }
        }

        return dp[coins.Length][amount];
    }

    public object Change_Ver2(int amount, int[] coins)
    {
        var dp = new int[amount + 1];

        dp[0] = 1;

        for (var j = 0; j <= amount; j++)
        {
            for (var i = 0; i < coins.Length; i++)
            {
                if (j - coins[i] >= 0)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }
        }

        return dp[amount];
    }
}