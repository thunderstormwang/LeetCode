using System;
using System.Collections.Generic;

namespace LeetCode.Solution0001_0050
{
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
        
        // 用暴力法
        // Time: O(N^3)
        // Space: O(1)
        
        //------------------------
        
        // 用 two pointer
        // 先做排序
        // 再輪詢每個元素, 再用兩個指標, 分別從該次元素的下一個位置(left), 和從陣列尾端(right)
        // 如果三者的和比較小, 將 left + 1, 反之將 right - 1
        // Time: O(log) + O(N^2) = O(N^2) 
        // Space: O(1)
    }
}