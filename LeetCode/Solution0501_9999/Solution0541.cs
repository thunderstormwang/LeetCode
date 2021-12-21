using System;
using System.Linq;

namespace LeetCode.Solution0501_9999
{
    public class Solution0541
    {
        public string ReverseStr(string s,
            int k)
        {
            var charArray = s.ToArray();
            var begin = 0;

            while (begin < s.Length)
            {
                var low = begin;
                var high = Math.Min(begin + k,
                    s.Length) - 1;

                while (low < high)
                {
                    (charArray[low], charArray[high]) = (charArray[high], charArray[low]);
                    low++;
                    high--;
                }

                begin += 2 * k;
            }

            return new string(charArray);
        }
        
        // Time: O(N)
        // Space: O(N)
    }
}