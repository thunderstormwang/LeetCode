namespace LeetCode.Solution0051_0100;

public class Solution0091
{
    public int NumDecodings(string s)
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