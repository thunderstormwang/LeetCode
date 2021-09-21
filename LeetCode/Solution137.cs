using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution137
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            var one = 0;
            var two = 0;
            var three = 0;

            foreach (var item in nums)
            {
                two |= one & item;
                one ^= item;
                three = one & two;
                one &= ~three;
                two &= ~three;
            }

            result = one;
            return result;
        }
    }
}