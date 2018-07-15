namespace LeetCode
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            s = s.ToLower();

            int left = 0;
            int right = s.Length - 1;

            while (right > left)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }

                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}