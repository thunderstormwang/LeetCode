using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution128
    {
        public int LongestConsecutive(int[] nums)
        {
            var result = 0;
            var hashSet = new HashSet<int>();
            foreach (var element in nums)
            {
                hashSet.Add(element);
            }

            foreach (var element in hashSet)
            {
                if (hashSet.Contains(element - 1))
                {
                    continue;
                }

                var currCount = 1;
                var currNum = element;
                while (hashSet.Contains(currNum + 1))
                {
                    currCount++;
                    currNum++;
                }

                result = Math.Max(result,
                    currCount);
            }

            return result;
        }
    }
}