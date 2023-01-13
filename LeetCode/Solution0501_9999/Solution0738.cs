using System.Text;

namespace LeetCode.Solution0501_9999;

public class Solution0738
{
    public int MonotoneIncreasingDigits(int n)
    {
        var strBuilder = new StringBuilder(n.ToString());
        var firstNineIndex = strBuilder.Length;
        for (var i = strBuilder.Length - 1; i > 0; i--)
        {
            if (strBuilder[i - 1] > strBuilder[i])
            {
                firstNineIndex = i;
                strBuilder[i] = '9';
                strBuilder[i - 1]--;
            }
        }

        for (var i = firstNineIndex; i < strBuilder.Length; i++)
        {
            strBuilder[i] = '9';
        }

        return Int32.Parse(strBuilder.ToString());
    }
}