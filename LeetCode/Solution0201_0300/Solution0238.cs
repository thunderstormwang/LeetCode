namespace LeetCode.Solution0201_0300;

public class Solution0238
{
    public int[] ProductExceptSelf_Ver1(int[] nums)
    {
        var result = new int[nums.Length];
        var left = new int [nums.Length];
        var right = new int [nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            left[i] = 1;
            right[i] = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i + 1];
        }

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = left[i] * right[i];
        }

        return result;
    }

    public int[] ProductExceptSelf_Ver2(int[] nums)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        var right = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= right;
            right *= nums[i];
        }

        return result;
    }
}