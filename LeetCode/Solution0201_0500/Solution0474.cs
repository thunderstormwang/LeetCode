using System.Text.RegularExpressions;

namespace LeetCode.Solution0201_0500;

public class Solution0474
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        var dp = new int [m + 1][];
        for (var i = 0; i < m + 1; i++)
        {
            dp[i] = new int[n + 1];
        }

        foreach (var item in strs)
        {
            var zero = 0;
            var one = 0;
            for (var i = 0; i < item.Length; i++)
            {
                if (item[i] == '0')
                {
                    zero++;
                }
                else
                {
                    one++;
                }
            }

            for (var i = m; i >= zero; i--)
            {
                for (var j = n; j >= one; j--)
                {
                    dp[i][j] = Math.Max(dp[i][j], dp[i - zero][j - one] + 1);
                }
            }
        }

        return dp[m][n];
    }
}