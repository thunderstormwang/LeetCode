using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0003
    {
        public int LengthOfLongestSubstring_Brutal(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (!ContainRepetition(s,
                        i,
                        j))
                    {
                        result = Math.Max(result,
                            j - i + 1);
                    }
                }
            }

            return result;
        }
        
        // 用暴力法

        public int LengthOfLongestSubstring_SlideWindow(string s)
        {
            var result = 0;
            var charSet = new HashSet<char>();

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i + charSet.Count; j < s.Length; j++)
                {
                    if (!charSet.Add(s[j]))
                    {
                        break;
                    }
                }

                result = Math.Max(result,
                    charSet.Count);
                charSet.Remove(s[i]);
            }

            return result;
        }

        public int LengthOfLongestSubstring_Linear(string s)
        {
            // Creating a set to store the last positions of occurrence
            var seen = new Dictionary<char, int>();
            var maximumLength = 0;

            // starting the initial point of window to index 0
            var start = 0;

            for (var end = 0; end < s.Length; end++)
            {
                // Checking if we have already seen the element or not
                if (seen.ContainsKey(s[end]))
                {
                    // If we have seen the number, move the start pointer
                    // to position after the last occurrence
                    start = Math.Max(start,
                        seen[s[end]] + 1);
                }

                // Updating the last seen value of the character
                seen[s[end]] = end;
                maximumLength = Math.Max(maximumLength,
                    end - start + 1);
            }

            return maximumLength;
        }

        private bool ContainRepetition(string input,
            int start,
            int end)
        {
            var charSet = new HashSet<char>();

            for (var i = start; i <= end; i++)
            {
                if (!charSet.Add(input[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}