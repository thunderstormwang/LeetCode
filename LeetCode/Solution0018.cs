using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0018
    {
        public IList<IList<int>> FourSum(int[] nums,
            int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            
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

            var k = 4;
            return FindKSum(nums,
                k,
                target,
                0);
        }

        private IList<IList<int>> FindKSum(int[] nums,
            int k,
            int target,
            int start)
        {
            IList<IList<int>> result = new List<IList<int>>();
            
            if (k == 2)
            {
                return FindTwoSum(nums,
                    target,
                    start);
            }

            for (var i = start; i <= nums.Length - k; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }

                var temp = FindKSum(nums,
                    k - 1,
                    target - nums[i],
                    i + 1);

                foreach (var item in temp)
                {
                    item.Insert(0,
                        nums[i]);
                    result.Add(item);
                }
            }

            return result;
        }

        private IList<IList<int>> FindTwoSum(int[] nums,
            int target,
            int start)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var lowIndex = start;
            var highIndex = nums.Length - 1;
            while (lowIndex < highIndex)
            {
                var twoSum = nums[lowIndex] + nums[highIndex];
                if (twoSum == target)
                {
                    result.Add(new List<int>() { nums[lowIndex], nums[highIndex] });

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
                else if (twoSum < target)
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