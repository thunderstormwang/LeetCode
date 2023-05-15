namespace LeetCode.Solution0501_9999;

public class Solution1049
{
    /// <summary>
    /// 01背包 2維陣列
    /// </summary>
    /// <param name="stones"></param>
    /// <returns></returns>
    public int LastStoneWeightII_Ver1(int[] stones)
    {
        var sum = stones.Sum();
        var halfWeight = sum / 2;
        var dp = new int[stones.Length][];

        for (var i = 0; i < stones.Length; i++)
        {
            dp[i] = new int[halfWeight + 1];
        }

        for (var i = 0; i < stones.Length; i++)
        {
            dp[i][0] = 0;
        }

        for (var j = stones[0]; j <= halfWeight; j++)
        {
            dp[0][j] = stones[0];
        }

        for (var i = 1; i < stones.Length; i++)
        {
            for (var j = 1; j <= halfWeight; j++)
            {
                if (j < stones[i])
                {
                    dp[i][j] = dp[i - 1][j];
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - stones[i]] + stones[i]);
                }
            }
        }

        return Math.Abs(2 * dp[stones.Length - 1][halfWeight] - sum);
    }

    /// <summary>
    /// 01背包 1維陣列
    /// </summary>
    /// <param name="stones"></param>
    /// <returns></returns>
    public int LastStoneWeightII_Ver2(int[] stones)
    {
        var sum = stones.Sum();
        var halfWeight = sum / 2;
        var dp = new int[halfWeight + 1];

        for (var j = stones[0]; j <= halfWeight; j++)
        {
            dp[j] = stones[0];
        }

        for (var i = 1; i < stones.Length; i++)
        {
            for (var j = halfWeight; j >= 1; j--)
            {
                if (j >= stones[i])
                {
                    dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);
                }
            }
        }

        return Math.Abs(2 * dp[halfWeight] - sum);
    }
}