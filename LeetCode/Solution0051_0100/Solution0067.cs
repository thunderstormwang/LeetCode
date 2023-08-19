using System.Text;

namespace LeetCode.Solution0051_0100;

public class Solution0067
{
    public string AddBinary_Ver1(string a, string b)
    {
        var result = string.Empty;
        var carry = 0;

        if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, '0');
        }
        else
        {
            b = b.PadLeft(a.Length, '0');
        }

        for (var i = a.Length - 1; i >= 0; i--)
        {
            var temp = Int32.Parse(a[i].ToString()) + Int32.Parse(b[i].ToString());
            temp += carry;
            result = result.PadLeft(result.Length + 1, (temp % 2).ToString()[0]);
            carry = (temp - temp % 2) / 2;
        }

        if (carry > 0)
        {
            result = result.PadLeft(result.Length + 1, '1');
        }

        return result;
    }

    public string AddBinary_Ver2(string a, string b)
    {
        var result = new StringBuilder();
        var pointer1 = a.Length - 1;
        var pointer2 = b.Length - 1;
        var carry = 0;

        while (pointer1 >= 0 || pointer2 >= 0)
        {
            var int1 = pointer1 >= 0 ? int.Parse(a.Substring(pointer1, 1)) : 0;
            var int2 = pointer2 >= 0 ? int.Parse(b.Substring(pointer2, 1)) : 0;
            var temp = int1 + int2 + carry;

            if (temp < 2)
            {
                carry = 0;
                result.Insert(0, temp.ToString());
            }
            else
            {
                carry = 1;
                temp %= 2;
                result.Insert(0, temp.ToString());
            }

            pointer1--;
            pointer2--;
        }

        if (carry > 0)
        {
            result.Insert(0, carry.ToString());
        }

        return result.ToString();
    }
}