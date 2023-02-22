namespace LeetCode.Solution0101_0200;

public class Solution0123
{
    public int MaxProfit(int[] prices)
    {
        var dp = new int[prices.Length][];
        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[4];
        }

        dp[0][0] = -prices[0];
        dp[0][1] = 0;
        dp[0][2] = -prices[0];
        dp[0][3] = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], -prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][0] + prices[i]);
            dp[i][2] = Math.Max(dp[i - 1][2], dp[i - 1][1] - prices[i]);
            dp[i][3] = Math.Max(dp[i - 1][3], dp[i - 1][2] + prices[i]);
        }

        return dp[prices.Length - 1][3];
    }
}