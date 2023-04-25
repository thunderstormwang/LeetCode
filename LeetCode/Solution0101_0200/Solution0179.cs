using System.Text;

namespace LeetCode.Solution0101_0200;

public class Solution0179
{
    public string LargestNumber(int[] nums)
    {
        Array.Sort(nums, (x, y) => string.CompareOrdinal($"{x}{y}", $"{y}{x}"));

        if (nums[nums.Length - 1] == 0)
        {
            return "0";
        }

        var sBuilder = new StringBuilder();
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            sBuilder.Append($"{nums[i]}");
        }

        return sBuilder.ToString();
    }
}