namespace LeetCode.Solution0151_0200;

public class Solution0190
{
    public uint ReverseBits_Ver1(uint n)
    {
        var result = 0U;
        var i = 0;

        while (i < 32)
        {
            result = result * 2 + n % 2;
            n /= 2;
            i++;
        }

        return result;
    }

    public uint ReverseBits_Ver2(uint n)
    {
        var result = 0U;
        var i = 0;

        while (i < 32)
        {
            result = (result << 1) + (n & 1);
            n >>= 1;
            i++;
        }

        return result;
    }
}