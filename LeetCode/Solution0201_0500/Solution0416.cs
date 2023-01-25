namespace LeetCode.Solution0201_0500;

public class Solution0416
{
    /// <summary>
    /// 2 維 Dynamic Programming 陣列
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

        var weight = sum / 2;
        var dp = new int [nums.Length][];
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = new int[weight + 1];
        }

        for (var i = 0; i < nums.Length; i++)
        {
            dp[i][0] = 0;
        }

        for (var j = nums[0]; j <= weight; j++)
        {
            dp[0][j] = nums[0];
        }

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 1; j <= weight; j++)
            {
                if (j < nums[i])
                {
                    dp[i][j] = dp[i - 1][j];
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - nums[i]] + nums[i]);
                }
            }
        }

        return dp[nums.Length - 1][weight] == weight;
    }

    /// <summary>
    /// 1 維 Dynamic Programming 陣列
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

        var weight = sum / 2;
        var dp = new int [weight + 1];
        
        for (var j = nums[0]; j <= weight; j++)
        {
            dp[j] = nums[0];
        }
        
        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = weight; j >= 1; j--)
            {
                if (j < nums[i])
                {
                    dp[j] = dp[j];
                }
                else
                {
                    dp[j] = Math.Max(dp[j], dp[j - nums[i]] + nums[i]);
                }
            }
        }

        return dp[weight] == weight;
    }
}