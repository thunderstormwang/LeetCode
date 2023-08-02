namespace LeetCode.Solution0501_0700;

public class Solution0692
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var dict = new Dictionary<string, int>();
        var priorityQueue = new PriorityQueue<(string Key, int Count), (string Key, int Count)>(new Comparer());
        var result = new List<string>();

        for (var i = 0; i < words.Length; i++)
        {
            if (!dict.ContainsKey(words[i]))
            {
                dict.Add(words[i], 0);
            }

            dict[words[i]]++;
        }

        foreach (var item in dict)
        {
            priorityQueue.Enqueue((item.Key, item.Value), (item.Key, item.Value));

            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        for (var i = 0; i < k; i++)
        {
            result.Add(priorityQueue.Dequeue().Key);
        }

        result.Reverse();
        return result;
    }

    public class Comparer : IComparer<(string Key, int Count)>
    {
        public int Compare((string Key, int Count) x, (string Key, int Count) y)
        {
            if (x.Count > y.Count)
            {
                return 1;
            }

            if (x.Count < y.Count)
            {
                return -1;
            }

            return -1 * string.Compare(x.Key, y.Key);
        }
    }
}