﻿namespace LeetCode.Solution0301_0500;

public class Solution0343
{
    public int IntegerBreak(int n)
    {
        var dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 1;

        for (var i = 3; i <= n; i++)
        {
            for (var j = 1; j < i; j++)
            {
                dp[i] = Math.Max(dp[i], j * (i - j));
                dp[i] = Math.Max(dp[i], j * dp[i - j]);
                dp[i] = Math.Max(dp[i], dp[j] * dp[i - j]);
            }
        }

        return dp[n];
    }
}