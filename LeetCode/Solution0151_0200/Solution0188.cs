namespace LeetCode.Solution0151_0150;

public class Solution0188
{
    public int MaxProfit(int k, int[] prices)
    {
        var dp = new int[prices.Length][];
        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[2 * k];
        }

        for (var j = 0; j < 2 * k; j++)
        {
            if (j % 2 == 0)
            {
                dp[0][j] = -prices[0];
            }
            else
            {
                dp[0][j] = 0;
            }
        }

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], -prices[i]);
        }
        for (var i = 1; i < prices.Length; i++)
        {
            for (var j = 1; j < 2 * k; j++)
            {
                if (j % 2 == 0)
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - 1] - prices[i]);
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - 1] + prices[i]);
                }
            }
        }

        return dp[prices.Length - 1][2 * k - 1];
    }
}