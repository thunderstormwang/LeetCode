namespace LeetCode.Solution0301_0500;

public class Solution0338
{
    public int[] CountBits_Ver1(int n)
    {
        var result = new int [n + 1];

        for (var i = 1; i <= n; i++)
        {
            var num = i;
            var count = 0;

            while (num != 0)
            {
                if (num % 2 == 1)
                {
                    count++;
                }

                num /= 2;
            }

            result[i] = count;
        }

        return result;
    }

    public int[] CountBits_Ver2(int n)
    {
        var dp = new int [n + 1];

        for (var i = 1; i <= n; i++)
        {
            dp[i] = dp[i / 2] + i % 2;
        }

        return dp;
    }

    public int[] CountBits_Ver3(int n)
    {
        var dp = new int [n + 1];

        for (var i = 1; i <= n; i++)
        {
            dp[i] = dp[i & (i - 1)] + 1;
        }

        return dp;
    }
}