namespace LeetCode.Solution0501_9999;

public class Solution0583
{
    public int MinDistance_Ver1(string word1, string word2)
    {
        var dp = new int[word1.Length + 1][];
        for (var i = 0; i < word1.Length + 1; i++)
        {
            dp[i] = new int[word2.Length + 1];
        }

        for (var i = 0; i < word1.Length; i++)
        {
            for (var j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    dp[i + 1][j + 1] = dp[i][j] + 1;
                }
                else
                {
                    dp[i + 1][j + 1] = Math.Max(dp[i + 1][j], dp[i][j + 1]);
                }
            }
        }

        return word1.Length + word2.Length - 2 * dp[word1.Length][word2.Length];
    }

    public int MinDistance_Ver2(string word1, string word2)
    {
        var dp = new int[word2.Length + 1];

        for (var i = 0; i < word1.Length; i++)
        {
            var pre = dp[0];
            for (var j = 0; j < word2.Length; j++)
            {
                var temp = dp[j + 1];
                if (word1[i] == word2[j])
                {
                    dp[j + 1] = pre + 1;
                }
                else
                {
                    dp[j + 1] = Math.Max(dp[j], dp[j + 1]);
                }

                pre = temp;
            }
        }

        return word1.Length + word2.Length - 2 * dp[word2.Length];
    }
}