namespace LeetCode.Solution0501_0700;

public class Solution0621
{
    public int LeastInterval_Ver1(char[] tasks, int n)
    {
        var result = 0;
        var cycle = n + 1;
        var array = new int [26];
        var priorityQueue = new PriorityQueue<int, int>();

        for (var i = 0; i < tasks.Length; i++)
        {
            array[tasks[i] - 'A']++;
        }

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                priorityQueue.Enqueue(-array[i], -array[i]);
            }
        }

        while (priorityQueue.Count != 0)
        {
            var count = 0;
            var list = new List<int>();

            while (priorityQueue.Count != 0 && count < cycle)
            {
                list.Add(priorityQueue.Dequeue() * -1);
                count++;
            }

            for (var i = 0; i < list.Count; i++)
            {
                list[i]--;
                if (list[i] > 0)
                {
                    priorityQueue.Enqueue(-list[i], -list[i]);
                }
            }

            result += priorityQueue.Count == 0 ? count : cycle;
        }

        return result;
    }

    public int LeastInterval_Ver2(char[] tasks, int n)
    {
        var array = new int [26];
        var maxFreq = 0;
        var maxTasks = 0;

        for(var i = 0; i < tasks.Length; i++)
        {
            array[tasks[i] - 'A']++;
        }

        for(var i = 0; i < array.Length; i++)
        {
            if(array[i] == maxFreq)
            {
                maxTasks++;
            }

            if(array[i] > maxFreq)
            {
                maxFreq = array[i];
                maxTasks = 1;
            }
        }

        return Math.Max((maxFreq - 1) * (n + 1) + maxTasks, tasks.Length);
    }
}