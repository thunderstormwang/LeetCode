﻿namespace LeetCode.Solution0000_0050
{
    public class Solution0028
    {
        public int StrStr(string haystack,
            string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                var j = 0;
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }

                if (j == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
        
        // Time: O(N*M), N: haystack 長度, M: needle 長度
        // Space: O(1)
    }
}