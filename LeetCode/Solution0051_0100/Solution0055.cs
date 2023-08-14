namespace LeetCode.Solution0051_0100;

public class Solution0055
{
    public bool CanJump_Ver1(int[] nums)
    {
        var dp = new int [nums.Length];
        dp[0] = nums[0];

        for (var i = 1; i < nums.Length && i <= dp[i - 1]; i++)
        {
            dp[i] = Math.Max(dp[i - 1], i + nums[i]);
        }

        return dp[nums.Length - 1] >= nums.Length - 1;
    }

    public bool CanJump_Ver2(int[] nums)
    {
        var max = nums[0];

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > max)
            {
                return false;
            }

            max = Math.Max(nums[i] + i, max);
        }

        return max >= nums.Length - 1;
    }
}