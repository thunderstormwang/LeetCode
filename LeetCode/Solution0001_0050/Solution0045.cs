namespace LeetCode.Solution0001_0050;

public class Solution0045
{
    public int Jump_DynamicProgramming(int[] nums)
    {
        var dp = new int[nums.Length];
        dp[0] = 0;
        for (var i = 1; i < dp.Length; i++)
        {
            dp[i] = int.MaxValue;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var start = i + 1;
            var end = i + nums[i];
            for (var j = start; j <= end && j < nums.Length; j++)
            {
                dp[j] = Math.Min(dp[j], dp[i] + 1);
            }
        }

        return dp[dp.Length - 1];
    }

    public int Jump_Greedy(int[] nums)
    {
        var start = 0;
        var end = 0;
        var maxFar = 0;
        var step = 0;

        while (maxFar < nums.Length - 1)
        {
            step++;
            for (var i = start; i <= end; i++)
            {
                maxFar = Math.Max(i + nums[i], maxFar);
            }

            start = end + 1;
            end = maxFar;
        }

        return step;
    }
}