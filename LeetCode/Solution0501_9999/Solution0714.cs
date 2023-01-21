namespace LeetCode.Solution0501_9999;

public class Solution0714
{
    public int MaxProfit(int[] prices, int fee)
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
}