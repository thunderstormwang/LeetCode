namespace LeetCode.Solution0301_0500;

public class Solution0474
{
    /// <summary>
    /// 三維陣列 Dynamic Programming 陣列
    /// </summary>
    /// <param name="strs"></param>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int FindMaxForm_Ver1(string[] strs, int m, int n)
    {
        var dp = new int [strs.Length + 1][][];
        for (var k = 0; k < strs.Length + 1; k++)
        {
            dp[k] = new int[m + 1][];
            for (var i = 0; i < m + 1; i++)
            {
                dp[k][i] = new int[n + 1];
            }
        }

        for (var k = 0; k < strs.Length; k++)
        {
            var zero = 0;
            var one = 0;
            for (var s = 0; s < strs[k].Length; s++)
            {
                if (strs[k][s] == '0')
                {
                    zero++;
                }
                else
                {
                    one++;
                }
            }

            for (var i = 0; i <= m; i++)
            {
                for (var j = 0; j <= n; j++)
                {
                    if (i >= zero && j >= one)
                    {
                        dp[k + 1][i][j] = Math.Max(dp[k][i][j], dp[k][i - zero][j - one] + 1);                        
                    }
                    else
                    {
                        dp[k + 1][i][j] = dp[k][i][j];
                    }
                }
            }
        }

        return dp[strs.Length][m][n];
    }

    /// <summary>
    /// 二維陣列 Dynamic Programming 陣列
    /// </summary>
    /// <param name="strs"></param>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int FindMaxForm_Ver2(string[] strs, int m, int n)
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