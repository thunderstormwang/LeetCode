namespace LeetCode
{
    public class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
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