namespace LeetCode.Solution0001_0050;

public class Solution0008
{
    public int MyAtoi(string s)
    {
        var digitStart = 0;
        var digitStr = string.Empty;
        var negative = false;
        var foundSign = false;
        var i = 0;

        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        while (i < s.Length && (s[i] < '0' || s[i] > '9') && !foundSign)
        {
            if (s[i] != ' ' && s[i] != '+' && s[i] != '-')
            {
                return 0;
            }

            switch (s[i])
            {
                case ' ':
                    break;
                case '+':
                case '-':
                {
                    if (foundSign)
                    {
                        return 0;
                    }

                    negative = s[i] == '-';
                    foundSign = true;
                    break;
                }
            }

            i++;
        }

        if (i >= s.Length || s[i] < '0' || s[i] > '9')
        {
            return 0;
        }

        digitStart = i;
        while (digitStart < s.Length && s[digitStart] == '0')
        {
            digitStart++;
        }

        i = digitStart;
        while (i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            i++;
        }

        digitStr = s.Substring(digitStart, i - digitStart);

        if (negative && "2147483648".Length < digitStr.Length)
        {
            return int.MinValue;
        }

        if (!negative && "2147483647".Length < digitStr.Length)
        {
            return int.MaxValue;
        }

        if (negative && "2147483648".Length == digitStr.Length && string.Compare("2147483648", digitStr) == -1)
        {
            return int.MinValue;
        }

        if (!negative && "2147483647".Length == digitStr.Length && string.Compare("2147483647", digitStr) == -1)
        {
            return int.MaxValue;
        }

        i = 0;
        var result = 0;

        while (i < digitStr.Length)
        {
            result = result * 10 + digitStr[i] - '0';
            i++;
        }

        return negative ? -result : result;
    }
}