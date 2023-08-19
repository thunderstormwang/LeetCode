namespace LeetCode.Solution0001_0050;

public class Solution0009
{
    public bool IsPalindrome_Ver1(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var str = x.ToString();
        var left = 0;
        var right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public bool IsPalindrome_Ver2(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var temp = x;
        var reverse = 0;

        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }

        return x == reverse;
    }

    public bool IsPalindrome_Ver3(int x)
    {
        if (x < 0 || (x != 0 && x % 10 == 0))
        {
            return false;
        }

        var reverseHalf = 0;

        while (x > reverseHalf)
        {
            reverseHalf = reverseHalf * 10 + x % 10;
            x /= 10;
        }

        return x == reverseHalf || x == reverseHalf / 10;
    }
}