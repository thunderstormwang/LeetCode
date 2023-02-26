namespace LeetCode.Solution0501_9999;

public class Solution0674
{
    public int FindLengthOfLCIS_DP(int[] nums)
    {
        var result = 1;
        var dp = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                dp[i] = dp[i - 1] + 1;
                result = Math.Max(result, dp[i]);
            }
        }

        return result;
    }

    public int FindLengthOfLCIS_Greedy(int[] nums)
    {
        var result = 1;
        var count = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                count++;
            }
            else
            {
                result = Math.Max(result, count);
                count = 1;
            }
        }
        result = Math.Max(result, count);

        return result;
    }
}