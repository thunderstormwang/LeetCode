using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0201_0500
{
    public class Solution0242
    {
        public bool IsAnagram_Version1(string s,
            string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item,
                        0);
                }

                dict[item] += 1;
            }

            foreach (var item in t)
            {
                if (!dict.ContainsKey(item))
                {
                    return false;
                }

                dict[item] -= 1;
                if (dict[item] < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsAnagram_Version2(string s,
            string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var record = new int[26];

            foreach (var item in s)
            {
                record[item - 'a'] += 1;
            }

            foreach (var item in t)
            {
                record[item - 'a'] -= 1;
            }

            return record.All(item => item >= 0);
        }

        // Time: O(N)
        // Space: O(N)
    }
}