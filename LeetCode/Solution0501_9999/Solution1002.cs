using System;
using System.Collections.Generic;

namespace LeetCode.Solution0501_9999
{
    public class Solution1002
    {
        public IList<string> CommonChars_Version1(string[] words)
        {
            var record = new int [words.Length][];
            for (var i = 0; i < record.Length; i++)
            {
                record[i] = new int[26];
            }

            for (var i = 0; i < words.Length; i++)
            {
                foreach (var item in words[i])
                {
                    record[i][item - 'a']++;
                }
            }

            var result = new List<string>();

            for (var j = 0; j < 26; j++)
            {
                var temp = int.MaxValue;
                foreach (var item in record)
                {
                    temp = Math.Min(temp,
                        item[j]);
                }

                while (temp > 0)
                {
                    result.Add(Convert.ToChar('a' + j).ToString());
                    temp--;
                }
            }

            return result;
        }

        public IList<string> CommonChars_Version2(string[] words)
        {
            var minRecord = new int [26];
            for (var j = 0; j < words[0].Length; j++)
            {
                minRecord[words[0][j] - 'a']++;
            }

            for (var i = 1; i < words.Length; i++)
            {
                var rowRecord = new int [26];
                for (var j = 0; j < words[i].Length; j++)
                {
                    rowRecord[words[i][j] - 'a']++;
                }

                for (var j = 0; j < rowRecord.Length; j++)
                {
                    minRecord[j] = Math.Min(minRecord[j], rowRecord[j]);
                }
            }

            var result = new List<string>();

            for (var j = 0; j < 26; j++)
            {
                while (minRecord[j] > 0)
                {
                    result.Add(Convert.ToChar('a' + j).ToString());
                    minRecord[j]--;
                }
            }

            return result;
        }

        // version 1
        // Time: O(M*N), M 個字串, 每個字串長度 N
        // Space: O(M*N)

        // =======

        // version 1
        // Time: O(M*N), M 個字串, 每個字串長度 N
        // Space: O(N)
    }
}