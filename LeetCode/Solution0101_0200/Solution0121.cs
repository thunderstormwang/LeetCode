namespace LeetCode.Solution0101_0200
{
    public class Solution0121
    {
        public int MaxProfit_Brutal(int[] prices)
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

        public int MaxProfit_Greedy(int[] prices)
        {
            var result = 0;
            var minPrice = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                result = Math.Max(result, prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }

            return result;
        }
        
        public int MaxProfit_DP(int[] prices)
        {
            var buy = new int [prices.Length];
            var sell = new int[prices.Length];

            buy[0] = prices[0];
            sell[0] = 0;
            
            for (var i = 1; i < prices.Length; i++)
            {
                buy[i] = Math.Min(buy[i - 1], prices[i]);
                sell[i] = Math.Max(sell[i - 1], prices[i] - buy[i]);
            }

            return sell[prices.Length - 1];
        }
    }
}