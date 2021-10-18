namespace LeetCode
{
    public class Solution0013
    {
        public int RomanToInt(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length - 1; i++)
            {
                var left = GetNumber(s[i]);
                var right = GetNumber(s[i + 1]);

                if (left < right)
                {
                    result -= left;
                }
                else
                {
                    result += left;
                }
            }

            return result + GetNumber(s[s.Length - 1]);
        }

        private int GetNumber(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;

                case 'C':
                    return 100;

                case 'D':
                    return 500;

                case 'M':
                    return 1000;

                default:
                    return 0;
            }
        }
    }
}