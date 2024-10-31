namespace LeetCode.Solution0101_0150;

public class Solution0122
{
    public int MaxProfit_Greedy(int[] prices)
    {
        var result = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] - prices[i - 1] > 0)
            {
                result += prices[i] - prices[i - 1];
            }
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
        dp[0][1] = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 1][1] - prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 1][0] + prices[i]);
        }

        return dp[prices.Length - 1][1];
    }
}