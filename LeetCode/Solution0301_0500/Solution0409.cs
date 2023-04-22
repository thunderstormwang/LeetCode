namespace LeetCode.Solution0301_0500;

public class Solution0409
{
    public int LongestPalindrome(string s)
    {
        var lower = new int[26];
        var upper = new int[26];
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                lower[s[i] - 'a']++;
                if (lower[s[i] - 'a'] == 2)
                {
                    lower[s[i] - 'a'] = 0;
                    result += 2;
                }
            }
            else
            {
                upper[s[i] - 'A']++;
                if (upper[s[i] - 'A'] == 2)
                {
                    upper[s[i] - 'A'] = 0;
                    result += 2;
                }
            }
        }

        for (var i = 0; i < lower.Length; i++)
        {
            if (lower[i] == 1)
            {
                return result + 1;
            }
        }

        for (var i = 0; i < upper.Length; i++)
        {
            if (upper[i] == 1)
            {
                return result + 1;
            }
        }

        return result;
    }
}