namespace LeetCode.Solution0301_0500;

public class Solution0377
{
    public int CombinationSum4(int[] nums, int target)
    {
        var dp = new int [target + 1];
        dp[0] = 1;

        for (var j = 0; j <= target; j++)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (j >= nums[i])
                {
                    dp[j] += dp[j - nums[i]];
                }
            }
        }

        return dp[target];
    }
}