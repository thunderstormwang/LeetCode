using System;

namespace LeetCode.Solution0201_9999
{
    public class Solution0279
    {
        public int NumSquares(int n)
        {
            var dp = new int[n + 1];

            for (var i = 1; i <= n; i++)
            {
                dp[i] = int.MaxValue;

                for (var j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i],
                        dp[i - j * j] + 1);
                }
            }

            return dp[n];
        }
        
        // 一開始想到的解法是 greedy 的方法
        // 找到僅次於 n 的平方數, 然後將 n 減去該平方數, 再找到下一個僅次於 n 的平方根
        // 但這做法並不會得到最佳解...
        // ex: 12 以上述做法會找到 9, 1, 1, 1, 用 4 個平方數組合, 但實際上可用 2 個平方數: 9 + 4
        
        // 用動態規劃
        // dp[n] 等於從 dp[n-1] + 1, dp[n-4] + 1, dp[n-9] + 1, ... 從中取最小
        
        // Time: O(N * sqrt(N))
        // Space: O(N)
    }
}