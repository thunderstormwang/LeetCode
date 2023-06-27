using System.Diagnostics;

namespace LeetCode.Solution0101_0150;

public class Solution0115
{
    public int NumDistinct_Ver1(string s, string t)
    {
        var dp = new int[s.Length + 1][];
        for (var i = 0; i < s.Length + 1; i++)
        {
            dp[i] = new int[t.Length + 1];
        }

        for (var i = 0; i < s.Length + 1; i++)
        {
            dp[i][0] = 1;
        }

        for (var j = 1; j < t.Length + 1; j++)
        {
            dp[0][j] = 0;
        }

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    dp[i + 1][j + 1] = dp[i][j] + dp[i][j + 1];
                }
                else
                {
                    dp[i + 1][j + 1] = dp[i][j + 1];
                }
            }

            Debug.WriteLine($"dp[{i + 1}], {string.Join(", ", dp[i + 1])}");
        }

        return dp[s.Length][t.Length];
    }
    
    public int NumDistinct_Ver2(string s, string t)
    {
        var dp = new int[t.Length+1];

        dp[0] = 1;
        for (var j = 1; j < t.Length + 1; j++)
        {
            dp[j] = 0;
        }

        for (var i = 0; i < s.Length; i++)
        {
            var pre = dp[0];
            for (var j = 0; j < t.Length; j++)
            {
                var temp = dp[j + 1];
                if (s[i] == t[j])
                {
                    dp[j + 1] = pre + dp[j + 1];
                }
                else
                {
                    dp[j + 1] = dp[j + 1];
                }

                pre = temp;
            }
        }

        return dp[t.Length];
    }
}