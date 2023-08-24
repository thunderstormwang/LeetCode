namespace LeetCode.Solution0001_0050;

public class Solution0050
{
    public double MyPow_Ver1(double x, int n)
    {
        long power = n;
        return n >= 0 ? Recursive(x, n) : Recursive(1 / x, -power);
    }

    public double MyPow_Ver2(double x, int n)
    {
        var result = 1d;
        long power = n;
        power = Math.Abs(power);
        var curr = x;

        while (power != 0)
        {
            if (power % 2 == 1)
            {
                result = result * curr;
            }

            curr = curr * curr;
            power /= 2;
        }

        if (n < 0)
        {
            result = 1 / result;
        }

        return result;
    }

    private double Recursive(double x, long n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n == 1)
        {
            return x;
        }

        var half = Recursive(x, n / 2);

        return half * half * (n % 2 == 1 ? x : 1);
    }
}