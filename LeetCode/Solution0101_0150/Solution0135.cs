namespace LeetCode.Solution0101_0150;

public class Solution0135
{
    public int Candy_Greedy01(int[] ratings)
    {
        var left2Right = new int [ratings.Length];
        var right2Left = new int [ratings.Length];
        var result = 0;

        left2Right[0] = 1;
        for (var i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                left2Right[i] = left2Right[i - 1] + 1;
            }
            else
            {
                left2Right[i] = 1;
            }
        }

        right2Left[ratings.Length - 1] = 1;
        for (var i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                right2Left[i] = right2Left[i + 1] + 1;
            }
            else
            {
                right2Left[i] = 1;
            }
        }

        for (var i = 0; i < ratings.Length; i++)
        {
            result += Math.Max(left2Right[i], right2Left[i]);
        }

        return result;
    }

    public int Candy_Greedy02(int[] ratings)
    {
        if (ratings.Length <= 1)
        {
            return ratings.Length;
        }

        var result = 0;
        var up = 0;
        var down = 0;
        var oldSlope = 0;

        for (var i = 1; i < ratings.Length; i++)
        {
            var newSlope = (ratings[i] > ratings[i - 1]) ? 1 : (ratings[i] < ratings[i - 1] ? -1 : 0);

            if ((oldSlope > 0 && newSlope == 0) || (oldSlope < 0 && newSlope >= 0))
            {
                result += Count(up) + Count(down) + Math.Max(up, down);
                up = 0;
                down = 0;
            }

            switch (newSlope)
            {
                case > 0:
                    up++;
                    break;
                case < 0:
                    down++;
                    break;
                case 0:
                    result++;
                    break;
            }

            oldSlope = newSlope;
        }

        result += Count(up) + Count(down) + Math.Max(up, down) + 1;
        return result;
    }

    private int Count(int n)
    {
        return (n * (n + 1)) / 2;
    }
}