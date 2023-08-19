namespace LeetCode.Solution0051_0100;

public class Solution0091
{
    public int NumDecodings_Ver1(string s)
    {
        if (s.Length == 1)
        {
            return s[0] == '0' ? 0 : 1;
        }

        var independent = new List<string>
        {
            "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "21", "22", "23", "24", "25", "26"
        };

        var mustBeCombine = new List<string>
        {
            "10", "20"
        };

        var dp = new int [s.Length + 1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;

        for (var i = 2; i < s.Length + 1; i++)
        {
            var str = s.Substring(i - 2, 2);

            if (independent.Contains(str))
            {
                dp[i] = dp[i - 2] + dp[i - 1];
                continue;
            }

            if (mustBeCombine.Contains(str))
            {
                dp[i] = dp[i - 2];
                continue;
            }

            if (s[i - 1] >= '1')
            {
                dp[i] = dp[i - 1];
            }
        }

        return dp[s.Length];
    }

    public int NumDecodings_Ver2(string s)
    {
        if (s.Length == 1)
        {
            return s[0] == '0' ? 0 : 1;
        }

        var list = new List<string>
        {
            "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "20", "21", "22", "23", "24", "25", "26"
        };

        var dp = new int [s.Length + 1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;

        for (var i = 2; i < s.Length + 1; i++)
        {
            if (s[i - 1] >= '1')
            {
                dp[i] += dp[i - 1];
            }

            var str = s.Substring(i - 2, 2);
            if (list.Contains(str))
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[s.Length];
    }
}