using LeetCode.Models;

namespace LeetCodeTests.SolutionTest0501_9999;

public class Solution0759
{
    public List<Interval> EmployeeFreeTime(List<List<Interval>> schedules)
    {
        var result = new List<Interval>();

        var flattens = schedules.SelectMany(s => s).ToList();

        flattens.Sort((x, y) =>
        {
            if (x.start < y.start)
            {
                return -1;
            }

            if (x.start > y.start)
            {
                return 1;
            }

            if (x.end < y.end)
            {
                return -1;
            }

            return 1;
        });

        var temp = flattens[0];

        for (var i = 1; i < flattens.Count; i++)
        {
            if (temp.end >= flattens[i].start)
            {
                temp.start = Math.Min(temp.start, flattens[i].start);
                temp.end = Math.Max(temp.end, flattens[i].end);
            }
            else
            {
                result.Add(new Interval()
                {
                    start = temp.end,
                    end = flattens[i].start
                });
                temp = flattens[i];
            }
        }

        return result;
    }
}