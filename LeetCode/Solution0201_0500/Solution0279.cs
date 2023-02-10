namespace LeetCode.Solution0201_0500
{
    public class Solution0279
    {
        /// <summary>
        /// 完全背包 二維陣列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares_Ver1(int n)
        {
            var square = 0;
            while (square * square <= n)
            {
                square++;
            }

            square--;

            var dp = new int[square + 1][];
            for (var i = 0; i < square + 1; i++)
            {
                dp[i] = new int[n + 1];
            }

            for (var j = 1; j < n + 1; j++)
            {
                dp[0][j] = int.MaxValue;
            }

            for (var i = 0; i < square + 1; i++)
            {
                dp[i][0] = 0;
            }

            for (var i = 1; i < square + 1; i++)
            {
                for (var j = 1; j < n + 1; j++)
                {
                    if (j < i * i)
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                    else
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - i * i] + 1);
                    }
                }
            }

            return dp[square][n];
        }

        /// <summary>
        /// 完全背包 一維陣列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares_Ver2(int n)
        {
            var dp = new int[n + 1];

            for (var j = 1; j < n + 1; j++)
            {
                dp[j] = int.MaxValue;
            }

            dp[0] = 0;

            for (var i = 1; i * i <= n; i++)
            {
                for (var j = 1; j < n + 1; j++)
                {
                    if (j >= i * i)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - i * i] + 1);
                    }
                }
            }

            return dp[n];
        }
    }
}