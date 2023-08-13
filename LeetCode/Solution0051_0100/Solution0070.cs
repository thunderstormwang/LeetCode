namespace LeetCode.Solution0051_0100;

public class Solution0070
{
    public int ClimbStairs_Ver1(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        var dp = new int [n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (var i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public int ClimbStairs_Ver2(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        var dp = new int [n + 1];
        dp[1] = 1;
        dp[2] = 2;

        return Recursive(dp, n);
    }

    public int ClimbStairs_Ver3(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        var pre = 1;
        var result = 2;

        for (var i = 3; i <= n; i++)
        {
            var temp = result;
            result += pre;
            pre = temp;
        }

        return result;
    }

    /// <summary>
    /// 動態規劃 - 完全背包 1維陣列
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ClimbStairs_Ver4(int n)
    {
        var dp = new int[n + 1];
        var step = new int[] { 1, 2 };

        dp[0] = 1;

        for (var j = 1; j <= n; j++)
        {
            for (var i = 0; i < step.Length; i++)
            {
                if (j >= step[i])
                {
                    dp[j] += dp[j - step[i]];
                }
            }
        }

        return dp[n];
    }

    private int Recursive(int[] dp, int i)
    {
        if (dp[i] != 0)
        {
            return dp[i];
        }

        dp[i] = Recursive(dp, i - 2) + Recursive(dp, i - 1);

        return dp[i];
    }
}