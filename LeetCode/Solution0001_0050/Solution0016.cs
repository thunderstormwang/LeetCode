using System;

namespace LeetCode.Solution0000_0050
{
    public class Solution0016
    {
        public int ThreeSumClosest(int[] nums,
            int target)
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