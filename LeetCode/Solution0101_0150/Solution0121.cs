namespace LeetCode.Solution0101_0150;

public class Solution0121
{
    public int MaxProfit_Brutal(int[] prices)
    {
        var result = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = i + 1; j < prices.Length; j++)
            {
                result = Math.Max(result, prices[j] - prices[i]);
            }
        }

        return result;
    }

    public int MaxProfit_Greedy(int[] prices)
    {
        var minPrice = prices[0];
        var result = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            result = Math.Max(result, prices[i] - minPrice);
        }

        return result;
    }

    public int MaxProfit_DP(int[] prices)
    {
        var dp = new int [prices.Length][];

        for (var i = 0; i < prices.Length; i++)
        {
            dp[i] = new int[2];
        }

        dp[0][0] = -prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], -prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][0] + prices[i]);
        }

        return dp[prices.Length - 1][1];
    }
}