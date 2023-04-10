namespace LeetCode.Solution0301_0500;

public class Solution0392
{
    public bool IsSubsequence_TwoPointer(string s, string t)
    {
        var j = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var foundMatch = false;
            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    foundMatch = true;
                    j++;
                    break;
                }

                j++;
            }

            if (!foundMatch && j == t.Length)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsSubsequence_DP_Ver1(string s, string t)
    {
        var dp = new int[t.Length + 1][];
        for (var i = 0; i < t.Length + 1; i++)
        {
            dp[i] = new int[s.Length + 1];
        }

        for (var i = 0; i < t.Length; i++)
        {
            for (var j = 0; j < s.Length; j++)
            {
                if (t[i] == s[j])
                {
                    dp[i + 1][j + 1] = dp[i][j] + 1;
                }
                else
                {
                    dp[i + 1][j + 1] = Math.Max(dp[i + 1][j], dp[i][j + 1]);
                }
            }
        }

        return dp[t.Length][s.Length] == s.Length;
    }
    
    public bool IsSubsequence_DP_Ver2(string s, string t)
    {
        var dp = new int[s.Length+1];

        for (var i = 0; i < t.Length; i++)
        {
            var pre = dp[0];
            for (var j = 0; j < s.Length; j++)
            {
                var temp = dp[j + 1];
                if (t[i] == s[j])
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

        return dp[s.Length] == s.Length;
    }
}