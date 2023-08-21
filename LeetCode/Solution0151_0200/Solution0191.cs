namespace LeetCode.Solution0151_0200;

public class Solution0191
{
    public int HammingWeight_Ver1(uint n)
    {
        var result = 0;

        while (n > 0)
        {
            result += (int)(n & 1);
            n >>= 1;
        }

        return result;
    }

    public int HammingWeight_Ver2(uint n)
    {
        var result = 0;

        while (n > 0)
        {
            result += (int)(n % 2);
            n /= 2;
        }

        return result;
    }

    public int HammingWeight_Ver3(uint n)
    {
        var result = 0;

        while (n != 0)
        {
            n &= (n - 1);
            result++;
        }

        return result;
    }
}