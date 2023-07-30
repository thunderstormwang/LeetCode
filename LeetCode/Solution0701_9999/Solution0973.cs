namespace LeetCode.Solution0701_9999;

public class Solution0973
{
    public int[][] KClosest_Ver1(int[][] points, int k)
    {
        var priorityQueue = new PriorityQueue<int[], int[]>(new Comparer());
        var result = new List<int[]>();

        for (var i = 0; i < points.Length; i++)
        {
            priorityQueue.Enqueue(points[i], points[i]);
            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        while (priorityQueue.Count != 0)
        {
            result.Add(priorityQueue.Dequeue());
        }

        return result.ToArray();
    }

    private class Comparer : IComparer<int[]>
    {
        /// <inheritdoc />
        public int Compare(int[]? x, int[]? y)
        {
            var xDistance = x[0] * x[0] + x[1] * x[1];
            var yDistance = y[0] * y[0] + y[1] * y[1];;

            if (xDistance == yDistance)
            {
                return 0;
            }

            return xDistance > yDistance ? -1 : 1;
        }
    }

    public int[][] KClosest_Ver2(int[][] points, int k)
    {
        var start = 0;
        var end = points.Length - 1;
        var result = new int [k][];

        var pos = Partition(points, start, end);

        while (pos != k - 1)
        {
            if (pos > k - 1)
            {
                end = pos - 1;
                pos = Partition(points, start, end);
            }

            if (pos < k - 1)
            {
                start = pos + 1;
                pos = Partition(points, start, end);
            }
        }

        Array.Copy(points, result, k);
        return result;
    }

    private int Partition(int[][] points, int start, int end)
    {
        var pivot = start;
        var pivotDistance = Distance(points[pivot]);
        var left = start + 1;
        var right = end;

        while (left <= right)
        {
            while (right >= pivot && Distance(points[right]) > pivotDistance)
            {
                right--;
            }

            while (left <= end && Distance(points[left]) <= pivotDistance)
            {
                left++;
            }

            if (left < right)
            {
                (points[left], points[right]) = (points[right], points[left]);
            }
        }

        (points[pivot], points[right]) = (points[right], points[pivot]);

        return right;
    }

    private int Distance(int[] point)
    {
        return point[0] * point[0] + point[1] * point[1];
    }
}