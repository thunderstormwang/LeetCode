﻿namespace LeetCode
{
    public class Solution58
    {
        public int LengthOfLastWord(string s)
        {
            string[] strArray = s.Split(' ');

            int i = strArray.Length - 1;
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