namespace LeetCode.Solution0301_0500;

public class Solution0452
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (x, y) =>
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

            if (x[1] > y[1])
            {
                return 1;
            }

            return 0;
        });

        var result = 1;
        
        for (var i = 1; i < points.Length; i++)
        {
            if (points[i-1][1] < points[i][0])
            {
                result++;
                continue;
            }

            points[i][1] = Math.Min(points[i - 1][1], points[i][1]);
        }

        return result;
    }
}