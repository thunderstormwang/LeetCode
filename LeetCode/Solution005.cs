using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution005
    {
        public string LongestPalindrome(string s)
        {
            var index = 0;
            var length = 0;
            var dpTable = new bool[s.Length, s.Length];

            for (var i = 0; i < s.Length; i++)
            {
                dpTable[i,
                    i] = true;

                if (1 > length)
                {
                    index = i;
                    length = 1;
                }
            }

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dpTable[i,
                        i + 1] = true;

                    if (2 > length)
                    {
                        index = i;
                        length = 2;
                    }
                }
            }

            for (var len = 3; len <= s.Length; len++)
            {
                for (var i = 0; i + len - 1 < s.Length; i++)
                {
                    if (s[i] == s[i + len - 1] && dpTable[i + 1,
                        i + len - 2])
                    {
                        dpTable[i,
                            i + len - 1] = true;

                        if (len > length)
                        {
                            index = i;
                            length = len;
                        }
                    }
                }
            }

            return s.Substring(index,
                length);
        }
    }
}