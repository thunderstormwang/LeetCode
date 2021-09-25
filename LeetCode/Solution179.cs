using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution179
    {
        private class Comparer : IComparer<int>
        {
            public int Compare(int x,
                int y)
            {
                var str1 = $"{x}{y}";
                var str2 = $"{y}{x}";
                return string.CompareOrdinal(str1,
                    str2);
            }
        }

        public string LargestNumber(int[] nums)
        {
            Array.Sort(nums,
                new Comparer());

            if (nums.Last().ToString()[0] == '0')
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
}