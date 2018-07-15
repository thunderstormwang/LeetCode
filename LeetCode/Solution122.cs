namespace LeetCode
{
    public class Solution122
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[i - 1] > 0)
                {
                    result += prices[i] - prices[i - 1];
                }
            }

            return result;
        }
    }
}