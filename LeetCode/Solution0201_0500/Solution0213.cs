﻿namespace LeetCodeTests.SolutionTest0201_0500;

public class Solution0213
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        var noFirst = Rob(nums, 1, nums.Length - 1);
        var noLast = Rob(nums, 0, nums.Length - 2);

        return Math.Max(noFirst, noLast);
    }

    private int Rob(int[] nums, int startIndex, int endIndex)
    {
        var dp = new int[endIndex - startIndex + 1];

        dp[0] = nums[startIndex];
        dp[1] = Math.Max(nums[startIndex], nums[startIndex + 1]);

        for (var i = 2; i < endIndex - startIndex + 1; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[startIndex + i]);
        }

        return dp[endIndex - startIndex];
    }
}