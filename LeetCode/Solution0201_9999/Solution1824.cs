using System;

namespace LeetCode.Solution0201_9999
{
    public class Solution1824
    {
        public int MinSideJumps(int[] obstacles)
        {
            var dp = new int [obstacles.Length][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int [3];
            }

            dp[0][0] = 1;
            dp[0][1] = 0;
            dp[0][2] = 1;

            for (var i = 1; i < obstacles.Length; i++)
            {
                for (var k = 0; k < 3; k++)
                {
                    if (obstacles[i - 1] == (k + 1) || obstacles[i] == (k + 1))
                    {
                        dp[i][k] = 999999;
                    }
                    else
                    {
                        var aLane = (k + 1) % 3;
                        var bLane = (k + 2) % 3;
                        dp[i][k] = Math.Min(dp[i - 1][k],
                            Math.Min(dp[i - 1][aLane],
                                dp[i - 1][bLane]) + 1);
                    }
                }
            }

            return Math.Min(dp[obstacles.Length - 1][0],
                Math.Min(dp[obstacles.Length - 1][1],
                    dp[obstacles.Length - 1][2]));
        }
        
        // 如果該賽道在 i 點有障礙, 即視為不可到達
        // 如果該賽道在 i-1 點有障礙, 即視 i 為不可到達
        
        // https://www.youtube.com/watch?v=6-49f0eystc
        // ??
    }
}