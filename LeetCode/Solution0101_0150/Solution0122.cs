using System.Diagnostics;

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
        var stock = new int[prices.Length];
        var noStock = new int[prices.Length];

        stock[0] = -prices[0];
        noStock[0] = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            stock[i] = Math.Max(stock[i - 1], noStock[i - 1] - prices[i]);
            noStock[i] = Math.Max(noStock[i - 1], stock[i - 1] + prices[i]);
        }

        return noStock[prices.Length - 1];
    }
}