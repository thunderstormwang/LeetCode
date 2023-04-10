namespace LeetCode.Solution0301_0500;

public class Solution0322
{
    /// <summary>
    /// 完全背包 二維陣列
    /// </summary>
    /// <param name="coins"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public int CoinChange_Ver1(int[] coins, int amount)
    {
        var dp = new int[coins.Length + 1][];
        for (var i = 0; i < coins.Length + 1; i++)
        {
            dp[i] = new int[amount + 1];
        }

        for (var i = 0; i < coins.Length + 1; i++)
        {
            dp[i][0] = 0;
        }

        for (var j = 1; j <= amount; j++)
        {
            dp[0][j] = -1;
        }

        for (var i = 0; i < coins.Length; i++)
        {
            for (var j = 1; j <= amount; j++)
            {
                if (j < coins[i])
                {
                    dp[i + 1][j] = dp[i][j];
                    continue;
                }

                if (dp[i][j] == -1 && dp[i + 1][j - coins[i]] == -1)
                {
                    dp[i + 1][j] = -1;
                }
                else if (dp[i][j] == -1)
                {
                    dp[i + 1][j] = dp[i + 1][j - coins[i]] + 1;
                }
                else if (dp[i + 1][j - coins[i]] == -1)
                {
                    dp[i + 1][j] = dp[i][j];
                }
                else
                {
                    dp[i + 1][j] = Math.Min(dp[i][j], dp[i + 1][j - coins[i]] + 1);
                }
            }
        }

        return dp[coins.Length][amount];
    }

    /// <summary>
    /// 完全背包 一維陣列
    /// </summary>
    /// <param name="coins"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public int CoinChange_Ver2(int[] coins, int amount)
    {
        var dp = new int[amount + 1];

        dp[0] = 0;
        for (var j = 1; j <= amount; j++)
        {
            dp[j] = -1;
        }

        for (var i = 0; i < coins.Length; i++)
        {
            for (var j = 1; j <= amount; j++)
            {
                if (j < coins[i])
                {
                    continue;
                }

                if (dp[j] == -1 && dp[j - coins[i]] == -1)
                {
                    dp[j] = -1;
                }
                else if (dp[j] == -1)
                {
                    dp[j] = dp[j - coins[i]] + 1;
                }
                else if (dp[j - coins[i]] == -1)
                {
                    dp[j] = dp[j];
                }
                else
                {
                    dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                }
            }
        }

        return dp[amount];
    }
}