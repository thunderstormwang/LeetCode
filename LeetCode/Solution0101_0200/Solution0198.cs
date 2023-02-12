namespace LeetCode.Solution0101_0200;

public class Solution0198
{
    public int Rob(int[] nums)
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
}