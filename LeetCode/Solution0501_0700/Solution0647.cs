namespace LeetCode.Solution0501_0700;

public class Solution0647
{
    public int CountSubstrings_MyAnswerVer1(string s)
    {
        var dp = new int[s.Length][];
        for (var i = 0; i < s.Length; i++)
        {
            dp[i] = new int[s.Length];
        }

        dp[0][0] = 1;

        for (var j = 1; j < s.Length; j++)
        {
            dp[0][j] += dp[0][j - 1];

            var tempStart = 0;
            while (tempStart <= j)
            {
                if (IsPalindrome(s, tempStart, j))
                {
                    dp[0][j]++;
                }

                tempStart++;
            }
        }

        return dp[0][s.Length - 1];
    }

    public int CountSubstrings_MyAnswerVer2(string s)
    {
        var dp = new int[s.Length];

        dp[0] = 1;

        for (var j = 1; j < s.Length; j++)
        {
            dp[j] += dp[j - 1];

            var tempStart = 0;
            while (tempStart <= j)
            {
                if (IsPalindrome(s, tempStart, j))
                {
                    dp[j]++;
                }

                tempStart++;
            }
        }

        return dp[s.Length - 1];
    }

    public int CountSubstrings_DP(string s)
    {
        var result = 0;
        var dp = new bool[s.Length][];
        for (var i = 0; i < s.Length; i++)
        {
            dp[i] = new bool[s.Length];
        }

        for (var j = 0; j < s.Length; j++)
        {
            for (var i = j; i >= 0; i--)
            {
                if (s[i] == s[j])
                {
                    if (i == j)
                    {
                        dp[i][j] = true;
                        result++;
                    }
                    else if (j - i == 1)
                    {
                        dp[i][j] = true;
                        result++;
                    }
                    else if (dp[i + 1][j - 1])
                    {
                        dp[i][j] = true;
                        result++;
                    }
                }
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            dp[i][i] = true;
        }

        return result;
    }

    public int CountSubstrings_TwoPointer(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            result += CountPalindrome(s, i, i);
            result += CountPalindrome(s, i, i + 1);
        }

        return result;
    }

    private int CountPalindrome(string s, int i, int j)
    {
        var result = 0;
        while (i >= 0 && j < s.Length)
        {
            if (s[i] != s[j])
            {
                break;
            }

            i--;
            j++;
            result++;
        }

        return result;
    }

    private bool IsPalindrome(string s, int i, int j)
    {
        while (i <= j)
        {
            if (s[i] != s[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}