namespace LeetCode.Solution0151_0150;

public class Solution0198
{
    public int Rob_Ver1(int[] nums)
    {
        var dp = new int[nums.Length + 1];

        dp[0] = 0;
        dp[1] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            dp[i + 1] = Math.Max(dp[i], dp[i - 1] + nums[i]);
        }

        return dp[nums.Length];
    }

    public int Rob_Ver2(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        var dp = new int [nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[1], nums[0]);

        for (var i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
        }

        return dp[nums.Length - 1];
    }
}