namespace LeetCode
{
    public class Solution038
    {
        public string CountAndSay(int n)
        {
            string formerString = string.Empty;
            string result = string.Empty;
            if (n == 1)
            {
                return "1";
            }
            else if (n == 2)
            {
                return "11";
            }
            else
            {
                formerString = CountAndSay(n - 1);
            }

            char currentChar = formerString[0];
            int repeat = 1;
            for (int i = 1; i < formerString.Length; i++)
            {
                if (formerString[i] != currentChar)
                {
                    result += repeat.ToString() + currentChar;
                    currentChar = formerString[i];
                    repeat = 1;
                }
                else
                {
                    repeat++;
                }
            }

            result += repeat.ToString() + currentChar;

            return result;
        }
    }
}