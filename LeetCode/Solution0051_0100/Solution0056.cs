namespace LeetCode.Solution0051_0100
{
    public class Solution0056
    {
        public int[][] Merge(int[][] intervals)
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

            var result = new List<int[]>()
            {
                intervals[0]
            };
            for (var i = 1; i < intervals.Length; i++)
            {
                if (result.Last()[1] >= intervals[i][0])
                {
                    result.Last()[1] = Math.Max(result.Last()[1], intervals[i][1]);
                }
                else
                {
                    result.Add(intervals[i]);
                }
            }

            return result.ToArray();
        }
    }
}