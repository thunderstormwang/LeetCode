using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution0056
    {
        public int[][] Merge(int[][] intervals)
        {
            for (var i = 0; i < intervals.Length - 1; i++)
            {
                for (var j = 0; j < intervals.Length - 1 - i; j++)
                {
                    if (intervals[j][0] > intervals[j + 1][0])
                    {
                        Swap(intervals,
                            j,
                            j + 1);
                    }
                }
            }

            var mergeList = new List<int[]>()
            {
                intervals[0]
            };
            for (var i = 1; i < intervals.Length; i++)
            {
                if (mergeList.Last()[1] >= intervals[i][0])
                {
                    mergeList.Last()[1] = Math.Max(mergeList.Last()[1],
                        intervals[i][1]);
                }
                else
                {
                    mergeList.Add(intervals[i]);
                }
            }

            return mergeList.ToArray();
        }

        private void Swap(int[][] intervals,
            int i,
            int j)
        {
            var temp = intervals[i];
            intervals[i] = intervals[j];
            intervals[j] = temp;
        }
    }
}