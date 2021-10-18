using System;

namespace LeetCode
{
    public class Solution0016
    {
        public int ThreeSumClosest(int[] nums,
            int target)
        {
            int[][] aa = new int[][] { new int[] { 1, 2 } };

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        Swap(nums,
                            i,
                            j);
                    }
                }
            }

            var threeSum = nums[0] + nums[1] + nums[2];
            for (var i = 0; i < nums.Length - 2; i++)
            {
                var lowIndex = i+1;
                var highIndex = nums.Length - 1;
                while (lowIndex < highIndex)
                {
                    var temp = nums[lowIndex] + nums[i] + nums[highIndex];
                    threeSum = Math.Abs(target - temp) < Math.Abs(target - threeSum) ? temp : threeSum;

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

            return threeSum;
        }

        private void Swap(int[] nums,
            int i,
            int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}