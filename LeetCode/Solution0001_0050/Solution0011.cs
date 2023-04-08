namespace LeetCode.Solution0001_0050;

public class Solution0011
{
    public int MaxArea(int[] height)
    {
        var lowIndex = 0;
        var highIndex = height.Length - 1;
        var result = 0;

        while (lowIndex < highIndex)
        {
            var currHeight = Math.Min(height[lowIndex], height[highIndex]);
            var area = currHeight * (highIndex - lowIndex);
            result = Math.Max(result, area);

            if (height[lowIndex] < height[highIndex])
            {
                lowIndex++;
            }
            else
            {
                highIndex--;
            }
        }

        return result;
    }
}