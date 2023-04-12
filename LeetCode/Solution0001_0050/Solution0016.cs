namespace LeetCode.Solution0001_0050;

public class Solution0016
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);

        var result = nums[0] + nums[1] + nums[2];
        for (var i = 0; i < nums.Length - 2; i++)
        {
            var lowIndex = i + 1;
            var highIndex = nums.Length - 1;
            while (lowIndex < highIndex)
            {
                var temp = nums[lowIndex] + nums[i] + nums[highIndex];
                result = Math.Abs(target - temp) < Math.Abs(target - result) ? temp : result;

                if (temp < target)
                {
                    lowIndex++;
                }
                else
                {
                    highIndex--;
                }
            }
        }

        return result;
    }
}