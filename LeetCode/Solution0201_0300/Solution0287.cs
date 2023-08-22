namespace LeetCode.Solution0201_0300;

public class Solution0287
{
    public int FindDuplicate_Ver1(int[] nums)
    {
        var mask = 1;
        var result = 0;
        var bitCount = 0;

        while (bitCount < 32)
        {
            var count1 = 0;
            var count2 = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if ((i & mask) > 0)
                {
                    count1++;
                }

                if ((nums[i] & mask) > 0)
                {
                    count2++;
                }
            }

            if (count2 > count1)
            {
                result += mask;
            }

            mask <<= 1;
            bitCount++;
        }

        return result;
    }

    public int FindDuplicate_Ver2(int[] nums)
    {
        var left = 1;
        var right = nums.Length;

        while (left < right)
        {
            var middle = left + (right - left) / 2;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= middle)
                {
                    count++;
                }
            }

            if (count <= middle)
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return right;
    }
}