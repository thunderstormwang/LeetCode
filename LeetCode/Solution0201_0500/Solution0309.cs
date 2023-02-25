namespace LeetCode.Solution0201_0500;

public class Solution0309
{
    public int MaxProfit_Ver1(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }

        var dp = new int[prices.Length][];
        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[2];
        }

        dp[0][0] = -prices[0];
        dp[0][1] = 0;
        dp[1][0] = Math.Max(dp[0][0], -prices[1]);
        dp[1][1] = Math.Max(dp[0][1], dp[0][0] + prices[1]);

        for (var i = 2; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 2][1] - prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][0] + prices[i]);
        }

        return dp[prices.Length - 1][1];
    }

    public int MaxProfit_Ver2(int[] prices)
    {
        var dp = new int[prices.Length][];
        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[4];
        }

        dp[0][0] = -prices[0];
        dp[0][1] = 0;
        dp[0][2] = 0;
        dp[0][3] = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], Math.Max(dp[i - 1][1], dp[i - 1][3]) - prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][3]);
            dp[i][2] = dp[i - 1][0] + prices[i];
            dp[i][3] = dp[i - 1][2];
        }

        return Math.Max(dp[prices.Length - 1][1], Math.Max(dp[prices.Length - 1][2], dp[prices.Length - 1][3]));
    }
}