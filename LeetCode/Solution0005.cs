namespace LeetCode
{
    public class Solution0005
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
            }

            index = 0;
            length = 1;

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    continue;
                }

                dpTable[i,
                    i + 1] = true;

                if (2 <= length)
                {
                    continue;
                }

                index = i;
                length = 2;
            }

            for (var len = 3; len <= s.Length; len++)
            {
                for (var i = 0; i + len - 1 < s.Length; i++)
                {
                    if (s[i] != s[i + len - 1] || !dpTable[i + 1,
                        i + len - 2])
                    {
                        continue;
                    }

                    dpTable[i,
                        i + len - 1] = true;

                    if (len <= length)
                    {
                        continue;
                    }

                    index = i;
                    length = len;
                }
            }

            return s.Substring(index,
                length);
        }
        
        // 暴力法
        // Time: O(n^3), Space: O(1)
        
        
    }
}