namespace LeetCode.Solution0501_9999;

public class Solution0977
{
    public int[] SortedSquares(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = new int [nums.Length];
        var index = nums.Length - 1;

        while (left <= right)
        {
            var leftPower = (int)Math.Pow(nums[left], 2);
            var rightPower = (int)Math.Pow(nums[right], 2);
            if (leftPower >= rightPower)
            {
                result[index--] = leftPower;
                left++;
            }
            else
            {
                result[index--] = rightPower;
                right--;
            }
        }

        return result;
    }
}