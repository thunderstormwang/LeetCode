namespace LeetCode.Solution0201_0300;

public class Solution0252
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) =>
        {
            if (x[0] < y[0])
            {
                return -1;
            }

            if (x[0] > y[0])
            {
                return 1;
            }

            if (x[1] < y[1])
            {
                return -1;
            }

            return 1;
        });

        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[i - 1][1])
            {
                return false;
            }
        }

        return true;
    }
}