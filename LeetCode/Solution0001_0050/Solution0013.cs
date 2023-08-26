namespace LeetCode.Solution0001_0050;

public class Solution0013
{
    public int RomanToInt_Ver1(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        var negativeDict = new HashSet<string>
        {
            "IV", "IX", "XL", "XC", "CD", "CM"
        };

        var result = 0;

        for (var i = 0; i < s.Length - 1; i++)
        {
            var str = s.Substring(i, 2);
            var isNegative = negativeDict.Contains(str);
            result += !isNegative ? dict[s[i]] : -dict[s[i]];
        }

        result += dict[s[s.Length - 1]];

        return result;
    }

    public int RomanToInt_Ver2(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        var result = 0;

        var curr = dict[s[0]];
        for (var i = 0; i < s.Length - 1; i++)
        {
            var next = dict[s[i + 1]];
            result += curr < next ? -curr : curr;
            curr = next;
        }

        result += dict[s[s.Length - 1]];

        return result;
    }

    private int GetNumber(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;

            case 'V':
                return 5;

            case 'X':
                return 10;

            case 'L':
                return 50;

            case 'C':
                return 100;

            case 'D':
                return 500;

            case 'M':
                return 1000;

            default:
                return 0;
        }
    }
}