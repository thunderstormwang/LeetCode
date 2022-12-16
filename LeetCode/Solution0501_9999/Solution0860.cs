namespace LeetCode.Solution0501_9999;

public class Solution0860
{
    public bool LemonadeChange(int[] bills)
    {
        var five = 0;
        var ten = 0;
        var twenty = 0;

        for (var i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                five++;
                continue;
            }

            if (bills[i] == 10)
            {
                ten++;
                five--;
                if (five < 0)
                {
                    return false;
                }

                continue;
            }

            if (bills[i] == 20)
            {
                if (ten > 0 && five > 0)
                {
                    twenty++;
                    ten--;
                    five--;
                }
                else if (five >= 3)
                {
                    twenty++;
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}