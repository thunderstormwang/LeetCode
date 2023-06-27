namespace LeetCode.Solution0701_9999;

public class Solution0714
{
    public int MaxProfit_Greedy(int[] prices, int fee)
    {
        var minPrice = prices[0];
        var result = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }

            if (prices[i] > minPrice + fee)
            {
                result += prices[i] - minPrice - fee;
                minPrice = prices[i] - fee;
            }
        }

        return result;
    }

    public int MaxProfit_DP(int[] prices, int fee)
    {
        var dp = new int [prices.Length][];
        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[2];
        }

        dp[0][0] = -prices[0];
        dp[0][1] = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 1][1] - prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][0] + prices[i] - fee);
        }

        return dp[prices.Length - 1][1];
    }
}