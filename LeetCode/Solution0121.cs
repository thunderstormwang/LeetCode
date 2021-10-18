namespace LeetCode
{
    public class Solution0121
    {
        public int MaxProfit(int[] prices)
        {
            var result = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    int tempProfit = prices[j] - prices[i];
                    if (tempProfit > result)
                    {
                        result = tempProfit;
                    }
                }
            }

            return result;
        }
    }
}