namespace LeetCode.Solution0001_0050;

public class Solution0005
{
    public string LongestPalindrome(string s)
    {
        var index = 0;
        var maxLength = 1;
        var dpTable = new bool[s.Length, s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            dpTable[i, i] = true;
        }

        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s[i] != s[i + 1])
            {
                continue;
            }

            dpTable[i, i + 1] = true;

            if (2 <= maxLength)
            {
                continue;
            }

            index = i;
            maxLength = 2;
        }

        for (var len = 3; len <= s.Length; len++)
        {
            for (var i = 0; i + len - 1 < s.Length; i++)
            {
                if (s[i] != s[i + len - 1] || !dpTable[i + 1, i + len - 2])
                {
                    continue;
                }

                dpTable[i, i + len - 1] = true;

                if (len <= maxLength)
                {
                    continue;
                }

                index = i;
                maxLength = len;
            }
        }

        return s.Substring(index, maxLength);
    }
}