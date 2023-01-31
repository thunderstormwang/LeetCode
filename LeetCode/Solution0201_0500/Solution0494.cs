namespace LeetCode.Solution0201_0500;

public class Solution0494
{
    /// <summary>
    /// 計算 dp[i][j]
    /// <br/>dp[0][offset] = 1;
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int FindTargetSumWays_Ver1_1(int[] nums, int target)
    {
        var sum = nums.Sum();

        if (Math.Abs(target) > sum)
        {
            return 0;
        }

        var offset = sum;
        var dp = new int[nums.Length + 1][];
        for (var i = 0; i <= nums.Length; i++)
        {
            dp[i] = new int[2 * sum + 1];
        }

        dp[0][offset] = 1;

        for (var i = 1; i <= nums.Length; i++)
        {
            for (var j = 0; j < 2 * sum + 1; j++)
            {
                var left = j - nums[i - 1] < 0 ? 0 : dp[i - 1][j - nums[i - 1]];
                var right = j + nums[i - 1] >= 2 * sum + 1 ? 0 : dp[i - 1][j + nums[i - 1]];
                dp[i][j] = left + right;
            }
        }

        return dp[nums.Length][target + offset];
    }

    /// <summary>
    /// 計算 dp[i][j]
    /// <br/>修改 1_1
    /// <br/>初始 dp[0][nums[0] + offset] = 1;
    /// <br/>初始 dp[0][-nums[0] + offset] = 1;
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int FindTargetSumWays_Ver1_2(int[] nums, int target)
    {
        var sum = nums.Sum();

        if (Math.Abs(target) > sum)
        {
            return 0;
        }

        var offset = sum;
        var dp = new int[nums.Length][];
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = new int[2 * sum + 1];
        }

        dp[0][nums[0] + offset] += 1;
        dp[0][-nums[0] + offset] += 1;

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < 2 * sum + 1; j++)
            {
                var left = j - nums[i] < 0 ? 0 : dp[i - 1][j - nums[i]];
                var right = j + nums[i] >= 2 * sum + 1 ? 0 : dp[i - 1][j + nums[i]];
                dp[i][j] = left + right;
            }
        }

        return dp[nums.Length - 1][target + offset];
    }

    /// <summary>
    /// 以 dp[i][j] 為來源做計算
    /// <br/>dp[0][offset] = 1;
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int FindTargetSumWays_Ver2_1(int[] nums, int target)
    {
        var sum = nums.Sum();

        if (Math.Abs(target) > sum)
        {
            return 0;
        }

        var offset = sum;
        var dp = new int[nums.Length + 1][];
        for (var i = 0; i <= nums.Length; i++)
        {
            dp[i] = new int[2 * sum + 1];
        }

        dp[0][offset] = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < 2 * sum + 1; j++)
            {
                if (dp[i][j] > 0)
                {
                    dp[i + 1][j - nums[i]] += dp[i][j];
                    dp[i + 1][j + nums[i]] += dp[i][j];
                }
            }
        }

        return dp[nums.Length][target + offset];
    }

    /// <summary>
    /// 以 dp[i][j] 為來源做計算
    /// <br/>修改 2_1
    /// <br/>dp[0][offset] = 1;
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int FindTargetSumWays_Ver2_2(int[] nums, int target)
    {
        var sum = nums.Sum();

        if (Math.Abs(target) > sum)
        {
            return 0;
        }

        var offset = sum;
        var dp = new int[nums.Length + 1][];
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = new int[2 * sum + 1];
        }

        dp[0][nums[0] + offset] += 1;
        dp[0][-nums[0] + offset] += 1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = 0; j < 2 * sum + 1; j++)
            {
                if (dp[i][j] > 0)
                {
                    dp[i + 1][j - nums[i + 1]] += dp[i][j];
                    dp[i + 1][j + nums[i + 1]] += dp[i][j];
                }
            }
        }

        return dp[nums.Length - 1][target + offset];
    }
}