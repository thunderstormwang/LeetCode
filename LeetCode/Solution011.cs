namespace LeetCode
{
    public class Solution011
    {
        public int MaxArea(int[] height)
        {
            var lowIndex = 0;
            var highIndex = height.Length - 1;
            var result = 0;

            while (lowIndex < highIndex)
            {
                var currHeight = height[lowIndex] < height[highIndex] ? height[lowIndex] : height[highIndex];
                var area = currHeight * (highIndex - lowIndex);
                
                result = result > area ? result : area;

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
}