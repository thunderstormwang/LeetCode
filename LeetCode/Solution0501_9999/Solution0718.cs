using System.Diagnostics;

namespace LeetCode.Solution0501_9999;

public class Solution0718
{
    public int FindLength_MyFirstAnswer(int[] nums1, int[] nums2)
    {
        var result = 0;
        var dp = new int[nums1.Length];

        for (var i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == nums2[0])
            {
                dp[i] = 1;
                result = 1;
            }
        }

        for (var j = 0; j < nums2.Length; j++)
        {
            if (nums1[0] == nums2[j])
            {
                dp[0] = 1;
                result = 1;
            }
        }

        for (var j = 1; j < nums2.Length; j++)
        {
            for (var i = nums1.Length - 1; i > 0; i--)
            {
                if (nums1[i] == nums2[j])
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i] = dp[i - 1] + 1;
                    }
                    else
                    {
                        dp[i] = 1;
                    }

                    result = Math.Max(result, dp[i]);
                }
            }
        }

        return result;
    }

    public int FindLength_Ver1(int[] nums1, int[] nums2)
    {
        var result = 0;
        var dp = new int[nums1.Length][];
        for (var i = 0; i < nums1.Length; i++)
        {
            dp[i] = new int[nums2.Length];
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == nums2[0])
            {
                dp[i][0] = 1;
                result = 1;
            }
        }

        for (var j = 0; j < nums2.Length; j++)
        {
            if (nums1[0] == nums2[j])
            {
                dp[0][j] = 1;
                result = 1;
            }
        }

        for (var i = 1; i < nums1.Length; i++)
        {
            for (var j = 1; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        dp[i][j] = 1;
                    }

                    result = Math.Max(result, dp[i][j]);
                }
            }
        }

        return result;
    }

    public int FindLength_Ver2(int[] nums1, int[] nums2)
    {
        var result = 0;
        var dp = new int[nums2.Length];

        for (var i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == nums2[0])
            {
                dp[0] = 1;
                result = 1;
            }
        }

        for (var j = 0; j < nums2.Length; j++)
        {
            if (nums1[0] == nums2[j])
            {
                dp[j] = 1;
                result = 1;
            }
        }

        for (var i = 1; i < nums1.Length; i++)
        {
            for (var j = nums2.Length - 1; j > 0; j--)
            {
                if (nums1[i] == nums2[j])
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[j] = dp[j - 1] + 1;
                    }
                    else
                    {
                        dp[j] = 1;
                    }

                    result = Math.Max(result, dp[j]);
                }
            }
        }

        return result;
    }
}