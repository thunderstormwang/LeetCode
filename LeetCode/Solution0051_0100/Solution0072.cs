using System.Diagnostics;

namespace LeetCode.Solution0051_0100;

public class Solution0072
{
    public int MinDistance_Ver1(string word1, string word2)
    {
        var dp = new int [word1.Length + 1][];
        for (var i = 0; i < word1.Length + 1; i++)
        {
            dp[i] = new int[word2.Length + 1];
        }

        for (var i = 0; i < word1.Length + 1; i++)
        {
            dp[i][0] = i;
        }

        for (var j = 0; j < word2.Length + 1; j++)
        {
            dp[0][j] = j;
        }

        for (var i = 0; i < word1.Length; i++)
        {
            for (var j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    dp[i + 1][j + 1] = dp[i][j];
                }
                else
                {
                    dp[i + 1][j + 1] = Math.Min(dp[i][j], Math.Min(dp[i + 1][j], dp[i][j + 1])) + 1;
                }
            }
        }

        return dp[word1.Length][word2.Length];
    }

    public int MinDistance_Ver2(string word1, string word2)
    {
        var dp = new int [word2.Length + 1];

        for (var j = 0; j < word2.Length + 1; j++)
        {
            dp[j] = j;
        }

        for (var i = 0; i < word1.Length; i++)
        {
            var pre = dp[0];
            dp[0] = i + 1;
            for (var j = 0; j < word2.Length; j++)
            {
                var temp = dp[j + 1];
                if (word1[i] == word2[j])
                {
                    dp[j + 1] = pre;
                }
                else
                {
                    dp[j + 1] = Math.Min(pre, Math.Min(dp[j], dp[j + 1])) + 1;
                }

                pre = temp;
            }
        }

        return dp[word2.Length];
    }
}