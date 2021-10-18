using System;

namespace LeetCode
{
    public class Solution0190
    {
        public uint ReverseBits(uint n)
        {
            var result = 0U;

            n >>= 0;
            result |= n & 1;

            var count = 1;
            while (count < 32)
            {
                n >>= 1;
                result <<= 1;
                result |= n & 1;
                count++;
            }
            
            return result;
        }
    }
}