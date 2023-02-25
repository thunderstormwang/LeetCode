namespace LeetCode.Solution0201_0500;

public class Solution0300
{
    public int LengthOfLIS(int[] nums)
    {
        var result = 1;
        var dp = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }

                result = Math.Max(result, dp[i]);
            }
        }

        return result;
    }
}