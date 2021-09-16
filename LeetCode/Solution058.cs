namespace LeetCode
{
    public class Solution58
    {
        public int LengthOfLastWord(string s)
        {
            var strArray = s.Split(' ');

            var i = strArray.Length - 1;
            while (i >= 0)
            {
                if (strArray[i].Length != 0)
                {
                    return strArray[i].Length;
                }
                i--;
            }

            return strArray[strArray.Length - 1].Length;
        }
    }
}