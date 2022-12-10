namespace LeetCode.Solution0101_0200;

public class Solution0122
{
    public int MaxProfit(int[] prices)
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
}