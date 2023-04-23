namespace LeetCode.Solution0051_0100;

public class Solution0076
{
    public string MinWindow_Ver1(string s, string t)
    {
        var bestLeft = -1;
        var minLength = int.MaxValue;
        var notMatched = 0;
        var dict = new Dictionary<char, int>();

        for (var i = 0; i < t.Length; i++)
        {
            if (!dict.ContainsKey(t[i]))
            {
                dict.Add(t[i], 1);
                notMatched++;
            }
            else
            {
                dict[t[i]]++;
            }
        }

        var left = 0;
        var right = 0;

        while (right < s.Length)
        {
            if (dict.ContainsKey(s[right]))
            {
                dict[s[right]]--;
                if (dict[s[right]] == 0)
                {
                    notMatched--;
                }
            }

            while (notMatched == 0)
            {
                if (minLength > right - left + 1)
                {
                    bestLeft = left;
                    minLength = right - left + 1;
                }

                if (dict.ContainsKey(s[left]))
                {
                    dict[s[left]]++;
                    if (dict[s[left]] > 0)
                    {
                        notMatched++;
                    }
                }

                left++;
            }

            right++;
        }

        return bestLeft == -1 ? string.Empty : s.Substring(bestLeft, minLength);
    }

    public string MinWindow_Ver2(string s, string t)
    {
        var minLength = int.MaxValue;
        var bestLeft = -1;
        var array = new int [128];
        var notMatched = 0;

        for (var i = 0; i < t.Length; i++)
        {
            if (array[t[i]] == 0)
            {
                notMatched++;
            }

            array[t[i]]++;
        }

        var left = 0;
        var right = 0;

        while (right < s.Length)
        {
            array[s[right]]--;
            if (array[s[right]] == 0)
            {
                notMatched--;
            }

            while (notMatched == 0)
            {
                array[s[left]]++;
                if (array[s[left]] > 0)
                {
                    notMatched++;
                }

                if (minLength > right - left + 1)
                {
                    minLength = right - left + 1;
                    bestLeft = left;
                }

                left++;
            }

            right++;
        }

        return bestLeft == -1 ? string.Empty : s.Substring(bestLeft, minLength);
    }
}