using System.Diagnostics;

namespace LeetCode.Solution0701_9999;

public class Solution1035
{
    // 跟 1143 一樣
    public int MaxUncrossedLines_Ver1(int[] nums1, int[] nums2)
    {
        var dp = new int[nums1.Length + 1][];
        for (var i = 0; i < nums1.Length + 1; i++)
        {
            dp[i] = new int[nums2.Length + 1];
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            for (var j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    dp[i + 1][j + 1] = dp[i][j] + 1;
                }
                else
                {
                    dp[i + 1][j + 1] = Math.Max(dp[i][j + 1], dp[i + 1][j]);
                }
            }

            Debug.WriteLine($"i={i}, {string.Join(", ", dp[i + 1])}");
        }

        return dp[nums1.Length][nums2.Length];
    }

    public int MaxUncrossedLines_Ver2(int[] nums1, int[] nums2)
    {
        var dp = new int[nums2.Length + 1];

        for (var i = 0; i < nums1.Length; i++)
        {
            var pre = dp[0];
            for (var j = 0; j < nums2.Length; j++)
            {
                var temp = dp[j + 1];
                if (nums1[i] == nums2[j])
                {
                    dp[j + 1] = pre + 1;
                }
                else
                {
                    dp[j + 1] = Math.Max(dp[j + 1], dp[j]);
                }

                pre = temp;
            }

            Debug.WriteLine($"i={i}, {string.Join(", ", dp)}");
        }

        return dp[nums2.Length];
    }
}