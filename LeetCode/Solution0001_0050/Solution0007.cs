namespace LeetCode.Solution0001_0050;

public class Solution0007
{
    public int Reverse_Ver1(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }

        var result = 0;
        var isNegative = x < 0;
        x = Math.Abs(x);

        while (x > 0)
        {
            if (result > 214748364)
            {
                return 0;
            }

            result = result * 10 + x % 10;
            x /= 10;
        }

        result *= isNegative ? -1 : 1;
        return result;
    }

    public int Reverse_Ver2(int x)
    {
        var negative = x < 0;
        var str = !negative ? x.ToString() : x.ToString().Substring(1);
        var charArray = str.ToArray();
        var left = 0;
        var right = charArray.Length - 1;

        while (left < right)
        {
            (charArray[left], charArray[right]) = (charArray[right], charArray[left]);
            left++;
            right--;
        }

        var newStr = new String(charArray);

        if (!negative)
        {
            if (newStr.Length <= 9)
            {
                return Int32.Parse(newStr);
            }

            if (string.Compare(newStr, "2147483647") != 1)
            {
                return Int32.Parse(newStr);
            }

            return 0;
        }

        newStr = '-' + newStr;
        if (newStr.Length <= 10)
        {
            return Int32.Parse(newStr);
        }

        if (string.Compare(newStr, "-2147483648") != 1)
        {
            return Int32.Parse(newStr);
        }

        return 0;
    }
}