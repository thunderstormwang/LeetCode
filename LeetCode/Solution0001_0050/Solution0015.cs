namespace LeetCode.Solution0001_0050;

public class Solution0015
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums);

        var target = 0;
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var lowIndex = i + 1;
            var highIndex = nums.Length - 1;
            while (lowIndex < highIndex)
            {
                var threeSum = nums[i] + nums[lowIndex] + nums[highIndex];
                if (threeSum == target)
                {
                    result.Add(new List<int>() { nums[i], nums[lowIndex], nums[highIndex] });

                    while (lowIndex < highIndex && nums[lowIndex] == nums[lowIndex + 1])
                    {
                        lowIndex++;
                    }

                    while (lowIndex < highIndex && nums[highIndex] == nums[highIndex - 1])
                    {
                        highIndex--;
                    }

                    lowIndex++;
                    highIndex--;
                }
                else if (threeSum < target)
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