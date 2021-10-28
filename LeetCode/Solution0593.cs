using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0593
    {
        public bool ValidSquare(int[] p1,
            int[] p2,
            int[] p3,
            int[] p4)
        {
            var lengthDict = new HashSet<double>();

            lengthDict.Add(LengthPower(p1,
                p2));
            lengthDict.Add(LengthPower(p1,
                p3));
            lengthDict.Add(LengthPower(p1,
                p4));
            
            lengthDict.Add(LengthPower(p2,
                p3));
            lengthDict.Add(LengthPower(p2,
                p4));
            
            lengthDict.Add(LengthPower(p3,
                p4));

            return lengthDict.Count == 2;
        }

        private double LengthPower(int[] p1,
            int[] p2)
        {
            return Math.Pow(p1[0] - p2[0],
                2) + Math.Pow(p1[1] - p2[1],
                2);
        }
    }
}