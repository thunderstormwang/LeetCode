namespace LeetCode.Solution0501_0700;

public class Solution0516
{
    public int LongestPalindromeSubseq(string s)
    {
        var dp = new int [s.Length][];
        for (var i = 0; i < s.Length; i++)
        {
            dp[i] = new int[s.Length];
        }

        for (var i = 0; i < s.Length; i++)
        {
            dp[i][i] = 1;
        }

        for (var i = s.Length - 1; i >= 0; i--)
        {
            for (var j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    dp[i][j] = dp[i + 1][j - 1] + 2;
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i + 1][j], dp[i][j - 1]);
                }
            }
        }

        return dp[0][s.Length - 1];
    }
}