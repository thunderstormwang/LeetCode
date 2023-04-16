namespace LeetCode.Solution0201_0300;

public class Solution0253
{
    public int MinMeetingRooms(int[][] intervals)
    {
        var start = new int[intervals.Length];
        var end = new int[intervals.Length];
        for (var i = 0; i < intervals.Length; i++)
        {
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }

        Array.Sort(start);
        Array.Sort(end);
        var startIndex = 0;
        var endIndex = 0;
        var result = 0;
        var active = 0;

        while (startIndex < intervals.Length && endIndex < intervals.Length)
        {
            if (start[startIndex] < end[endIndex])
            {
                active++;
                startIndex++;
            }
            else
            {
                active--;
                endIndex++;
            }

            result = Math.Max(result, active);
        }

        return result;
    }

    public int MinMeetingRooms_PriorityQueue(int[][] intervals)
    {
        var priorityQueue = new PriorityQueue<int[], int[]>(new IntervalComparer());
        var result = 0;

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

        for (var i = 0; i < intervals.Length; i++)
        {
            if (priorityQueue.Count != 0)
            {
                var top = priorityQueue.Peek();
                if (top[1] <= intervals[i][0])
                {
                    priorityQueue.Dequeue();
                }
            }

            priorityQueue.Enqueue(intervals[i], intervals[i]);
            result = Math.Max(result, priorityQueue.Count);
        }

        return result;
    }

    public int MinMeetingRooms_SortedList(int[][] intervals)
    {
        var sortedList = new SortedList<int[], int[]>(new IntervalComparer());
        var result = 0;

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

        for (var i = 0; i < intervals.Length; i++)
        {
            if (sortedList.Count != 0)
            {
                var top = sortedList.Values[0];
                if (top[1] <= intervals[i][0])
                {
                    sortedList.RemoveAt(0);
                }
            }

            sortedList.Add(intervals[i], intervals[i]);
            result = Math.Max(result, sortedList.Count);
        }

        return result;
    }

    public class IntervalComparer : IComparer<int[]>
    {
        /// <inheritdoc />
        public int Compare(int[]? x, int[]? y)
        {
            if (x[1] < y[1])
            {
                return -1;
            }

            return 1;
        }
    }
}