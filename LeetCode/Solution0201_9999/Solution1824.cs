using System;

namespace LeetCode.Solution0201_9999
{
    public class Solution1824
    {
        public int MinSideJumps(int[] obstacles)
        {
            var dp = new int[] { 1, 0, 1 };

            for (var i = 1; i < obstacles.Length; i++)
            {
                if (obstacles[i] != 0)
                {
                    dp[obstacles[i] - 1] = Int32.MaxValue - 1;
                }

                for (var j = 0; j < 3; j++)
                {
                    if (obstacles[i] == j + 1)
                    {
                        continue;
                    }

                    var aLane = (j + 1) % 3;
                    var bLane = (j + 2) % 3;
                    dp[j] = Math.Min(dp[j],
                        Math.Min(dp[aLane],
                            dp[bLane]) + 1);
                }
            }

            return Math.Min(dp[0],
                Math.Min(dp[1],
                    dp[2]));
        }
        
        // https://www.youtube.com/watch?v=6-49f0eystc

        // Time: O(N)
        // Space: O(1)
    }
}