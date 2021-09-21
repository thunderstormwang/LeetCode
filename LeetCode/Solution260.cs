using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution260
    {
        public int[] SingleNumber(int[] nums)
        {
            var result = new int[2];
            var xorTemp = 0;
            foreach (var item in nums)
            {
                xorTemp ^= item;
            }

            var mask = (xorTemp & (~ (xorTemp - 1)));

            foreach (var item in nums)
            {
                if ((item & mask) == 0)
                {
                    result[0] ^= item;
                }
                else
                {
                    result[1] ^= item;
                }
            }

            return result;
        }
    }
}