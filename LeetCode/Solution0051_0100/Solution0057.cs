namespace LeetCode.Solution0051_0100;

public class Solution0057
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        var i = 0;
        var newIntervalAdded = false;

        for (i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                continue;
            }

            if (intervals[i][0] > newInterval[1])
            {
                result.Add(newInterval);
                newIntervalAdded = true;
                break;
            }

            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
        }

        for (; i < intervals.Length; i++)
        {
            result.Add(intervals[i]);
        }

        if (!newIntervalAdded)
        {
            result.Add(newInterval);
        }

        return result.ToArray();
    }
}