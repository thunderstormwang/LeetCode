namespace LeetCode.Solution0151_0200;

public class Solution0152
{
    public int MaxProduct_Ver1(int[] nums)
    {
        var maxDp = new int [nums.Length];
        var minDp = new int [nums.Length];
        var result = nums[0];

        maxDp[0] = nums[0];
        minDp[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            var temp = Math.Max(maxDp[i - 1] * nums[i], minDp[i - 1] * nums[i]);
            maxDp[i] = Math.Max(temp, nums[i]);

            temp = Math.Min(maxDp[i - 1] * nums[i], minDp[i - 1] * nums[i]);
            minDp[i] = Math.Min(temp, nums[i]);

            result = Math.Max(result, maxDp[i]);
        }

        return result;
    }

    public int MaxProduct_Ver2(int[] nums)
    {
        var max = nums[0];
        var min = nums[0];
        var result = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            var preMax = max;
            var preMin = min;

            var temp = Math.Max(preMax * nums[i], preMin * nums[i]);
            max = Math.Max(temp, nums[i]);

            temp = Math.Min(preMax * nums[i], preMin * nums[i]);
            min = Math.Min(temp, nums[i]);

            result = Math.Max(result, max);
        }

        return result;
    }

    public int MaxProduct_Ver3(int[] nums)
    {
        var max = nums[0];
        var min = nums[0];
        var result = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                (max, min) = (min, max);
            }

            max = Math.Max(max * nums[i], nums[i]);
            min = Math.Min(min * nums[i], nums[i]);

            result = Math.Max(result, max);
        }

        return result;
    }
}