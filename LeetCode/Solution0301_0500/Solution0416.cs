namespace LeetCode.Solution0301_0500;

public class Solution0416
{
    /// <summary>
    /// 01 背包 2維陣列
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanPartition_Ver1(int[] nums)
    {
        var sum = nums.Sum();
        if (sum % 2 == 1)
        {
            return false;
        }

        var targetSum = sum / 2;
        var dp = new int [nums.Length + 1][];
        for (var i = 0; i <= nums.Length; i++)
        {
            dp[i] = new int[targetSum + 1];
        }

        for (var i = 1; i <= nums.Length; i++)
        {
            for (var j = 1; j <= targetSum; j++)
            {
                if (j < nums[i - 1])
                {
                    dp[i][j] = dp[i - 1][j];
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - nums[i - 1]] + nums[i - 1]);
                }
            }
        }

        return dp[nums.Length][targetSum] == targetSum;
    }

    /// <summary>
    /// 01 背包 1維陣列
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanPartition_Ver2(int[] nums)
    {
        var sum = nums.Sum();

        if (sum % 2 == 1)
        {
            return false;
        }

        var targetSum = sum / 2;
        var dp = new int [targetSum + 1];

        for (var i = 1; i <= nums.Length; i++)
        {
            for (var j = targetSum; j >= nums[i - 1]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - nums[i - 1]] + nums[i - 1]);
            }
        }

        return dp[targetSum] == targetSum;
    }
}