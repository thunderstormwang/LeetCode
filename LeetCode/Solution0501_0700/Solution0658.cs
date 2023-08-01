namespace LeetCode.Solution0501_0700;

public class Solution0658
{
    public IList<int> FindClosestElements_Ver1(int[] arr, int k, int x)
    {
        var result = new List<int>();
        var priorityQueue = new PriorityQueue<int, int>(new Comparer(x));

        for (var i = 0; i < arr.Length; i++)
        {
            priorityQueue.Enqueue(arr[i], arr[i]);
            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        while (priorityQueue.Count > 0)
        {
            result.Add(priorityQueue.Dequeue());
        }

        result.Sort();

        return result;
    }

    public IList<int> FindClosestElements_Ver2(int[] arr, int k, int x)
    {
        var result = new List<int>();
        var left = 0;
        var right = arr.Length - 1;

        while (right - left + 1 > k)
        {
            if (Math.Abs(arr[left] - x) < Math.Abs(arr[right] - x))
            {
                right--;
                continue;
            }

            if (Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x))
            {
                left++;
                continue;
            }

            if (arr[left] <= arr[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        while (left <= right)
        {
            result.Add(arr[left]);
            left++;
        }

        return result;
    }

    public class Comparer : IComparer<int>
    {
        private readonly int _x;

        public Comparer(int x)
        {
            _x = x;
        }

        public int Compare(int v1, int v2)
        {
            if (Math.Abs(v1 - _x) > Math.Abs(v2 - _x))
            {
                return -1;
            }

            if (Math.Abs(v1 - _x) < Math.Abs(v2 - _x))
            {
                return 1;
            }

            return v1 > v2 ? -1 : 1;
        }
    }
}