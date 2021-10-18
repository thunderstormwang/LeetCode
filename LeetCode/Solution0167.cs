namespace LeetCode
{
    public class Solution0167
    {
        public int[] TwoSum(int[] numbers,
            int target)
        {
            var lowIndex = 0;
            var highIndex = numbers.Length - 1;
            while (lowIndex < highIndex)
            {
                var temp = numbers[lowIndex] + numbers[highIndex];
                if (temp == target)
                {
                    break;
                }
                else if (temp < target)
                {
                    lowIndex++;
                }
                else
                {
                    highIndex--;
                }
            }

            return new int[] { lowIndex + 1, highIndex + 1 };
        }
    }
}