namespace LeetCode.Solution0301_0500;

public class Solution0376
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        var result = 1;
        var preDiff = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var currDiff = nums[i] - nums[i - 1];
            if ((currDiff < 0 && preDiff >= 0) || (currDiff > 0 && preDiff <= 0))
            {
                preDiff = currDiff;
                result++;
            }
        }

        return result;
    }
}