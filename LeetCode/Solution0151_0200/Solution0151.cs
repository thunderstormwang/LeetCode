namespace LeetCode.Solution0151_0150
{
    public class Solution0151
    {
        public string ReverseWords(string s)
        {
            // 移除多餘的空白
            // 反轉字串
            // 反轉每個單字

            var charArray = s.ToCharArray();
            var slow = charArray.Length - 1;
            var fast = charArray.Length - 1;
            while (fast >= 0 && charArray[fast] == ' ')
            {
                fast--;
            }

            while (fast >= 0)
            {
                if (charArray[fast] == ' ')
                {
                    while (fast >= 1 && charArray[fast - 1] == ' ')
                    {
                        fast--;
                    }
                }

                (charArray[slow], charArray[fast]) = (charArray[fast], charArray[slow]);
                slow--;
                fast--;
            }

            Reverse(charArray,
                0,
                charArray.Length - 1);

            slow = 0;
            while (slow < charArray.Length)
            {
                fast = slow;
                while (fast + 1 < charArray.Length && charArray[fast + 1] != ' ')
                {
                    fast++;
                }

                Reverse(charArray,
                    slow,
                    fast);

                slow = fast + 2;
            }

            var end = charArray.Length - 1;
            while (charArray[end] == ' ')
            {
                end--;
            }

            return new string(charArray,
                0,
                end + 1);
        }

        private void Reverse(char[] array,
            int start,
            int end)
        {
            while (start < end)
            {
                (array[start], array[end]) = (array[end], array[start]);
                start++;
                end--;
            }
        }

        // Time: O(N)
        // Space: O(1)
    }
}