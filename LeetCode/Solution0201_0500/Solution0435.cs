namespace LeetCode.Solution0201_0500;

public class Solution0435
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) =>
        {
            if (x[1] < y[1])
            {
                return -1;
            }

            if (x[1] > y[1])
            {
                return 1;
            }

            if (x[0] < y[0])
            {
                return -1;
            }

            return 1;
        });

        var result = 0;
        var right = intervals[0][1];
        for (var i = 1; i < intervals.Length; i++)
        {
            if (right > intervals[i][0])
            {
                result++;
            }
            else
            {
                right = intervals[i][1];
            }
        }

        return result;
    }
}