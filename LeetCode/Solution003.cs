using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution003
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
                        result = Math.Max(result,
                            j - i);
                        break;
                    }
                }

                charSet.Remove(s[i]);
            }
            
            return result;
        }

        public int LengthOfLongestSubstring_Linear(string s)
        {
            var result = 0;
            var charSet = new HashSet<char>();
            var currentHead = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (!charSet.Add(s[i]))
                {
                    result = Math.Max(result,
                        i - currentHead);
                    currentHead = i;
                    i = currentHead - 1;
                    charSet.RemoveWhere(c => true);
                }
            }
            
            return result;
        }

        private bool ContainRepetition(string input,
            int start,
            int end)
        {
            var charSet = new HashSet<char>();
            
            for (int i = start; i <= end; i++)
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