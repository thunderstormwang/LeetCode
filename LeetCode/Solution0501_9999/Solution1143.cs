using System.Diagnostics;

namespace LeetCode.Solution0501_9999;

public class Solution1143
{
    public int LongestCommonSubsequence_Ver1(string text1, string text2)
    {
        var dp = new int[text1.Length + 1][];
        for (var i = 0; i < text1.Length + 1; i++)
        {
            dp[i] = new int[text2.Length + 1];
        }

        for (var i = 0; i < text1.Length; i++)
        {
            for (var j = 0; j < text2.Length; j++)
            {
                if (text1[i] == text2[j])
                {
                    dp[i + 1][j + 1] = dp[i][j] + 1;
                }
                else
                {
                    dp[i + 1][j + 1] = Math.Max(dp[i][j + 1], dp[i + 1][j]);
                }
            }

            Debug.WriteLine($"i = {i}, {string.Join(", ", dp[i + 1])}");
        }

        return dp[text1.Length][text2.Length];
    }

    public int LongestCommonSubsequence_Ver2(string text1, string text2)
    {
        var dp = new int[text2.Length + 1];

        for (var i = 0; i < text1.Length; i++)
        {
            var pre = dp[0];
            for (var j = 0; j < text2.Length; j++)
            {
                var curr = dp[j + 1];
                if (text1[i] == text2[j])
                {
                    dp[j + 1] = pre + 1;
                }
                else
                {
                    dp[j + 1] = Math.Max(dp[j + 1], dp[j]);
                }

                pre = curr;
            }
        }

        return dp[text2.Length];
    }
}