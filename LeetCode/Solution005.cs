using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution005
    {
        public string LongestPalindrome(string s)
        {
            var preIndex = 0;
            var nextIndex = 0;
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 1; i - j >= 0 && i + j < s.Length; j++)
                {
                    if (CheckPalindrome(s.Substring(i - j + 1,
                        2 * j)))
                    {
                        if (nextIndex - preIndex + 1 < 2 * j)
                        {
                            preIndex = i - j + 1;
                            nextIndex = i + j;
                        }
                    }

                    if (CheckPalindrome(s.Substring(i - j,
                        2 * j + 1)))
                    {
                        if (nextIndex - preIndex + 1 < 2 * j + 1)
                        {
                            preIndex = i - j;
                            nextIndex = i + j;
                        }
                    }
                }
            }

            return s.Substring(preIndex,
                nextIndex - preIndex + 1);
        }

        private bool CheckPalindrome(string input)
        {
            var reverse = string.Join(string.Empty,
                input.Reverse());

            return input == reverse;
        }
    }
}