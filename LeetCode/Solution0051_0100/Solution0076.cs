namespace LeetCode.Solution0051_0100;

public class Solution0076
{
    public string MinWindow_Ver1(string s, string t)
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
                if (minLength > right - left + 1)
                {
                    minLength = right - left + 1;
                    bestLeft = left;
                }

                array[s[left]]++;
                if (array[s[left]] > 0)
                {
                    notMatched++;
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
            while(right < s.Length && notMatched != 0)
            {
                array[s[right]]--;
                if (array[s[right]] == 0)
                {
                    notMatched--;
                }

                right++;
            }
            
            while (notMatched == 0)
            {
                if (minLength > right - 1 - left + 1)
                {
                    minLength = right - 1 - left + 1;
                    bestLeft = left;
                }

                array[s[left]]++;
                if (array[s[left]] > 0)
                {
                    notMatched++;
                }

                left++;
            }
        }

        return bestLeft == -1 ? string.Empty : s.Substring(bestLeft, minLength);
    }
}