namespace LeetCode.Solution0501_0700;

public class Solution0632
{
    public int[] SmallestRange_Ver1(IList<IList<int>> nums)
    {
        var priorityQueue = new PriorityQueue<(int Value, int ListIndex), int>();
        var listIndexes = new int [nums.Count];
        var currMax = int.MinValue;

        for (var i = 0; i < nums.Count; i++)
        {
            priorityQueue.Enqueue((nums[i][0], i), nums[i][0]);
            currMax = Math.Max(currMax, nums[i][0]);
        }

        var result = new int[] { priorityQueue.Peek().Value, currMax };

        while (listIndexes[priorityQueue.Peek().ListIndex] < nums[priorityQueue.Peek().ListIndex].Count - 1)
        {
            var targetList = priorityQueue.Dequeue().ListIndex;
            listIndexes[targetList]++;
            var newValue = nums[targetList][listIndexes[targetList]];
            currMax = Math.Max(currMax, newValue);
            priorityQueue.Enqueue((newValue, targetList), newValue);

            if (currMax - priorityQueue.Peek().Value < result[1] - result[0])
            {
                result = new int[] { priorityQueue.Peek().Value, currMax };
            }
        }

        return result;
    }

    public int[] SmallestRange_Ver2(IList<IList<int>> nums)
    {
        var list = new List<(int Value, int ListIndex)>();
        for (var i = 0; i < nums.Count; i++)
        {
            for (var j = 0; j < nums[i].Count; j++)
            {
                list.Add((nums[i][j], i));
            }
        }

        list.Sort((x, y) => { return x.Value <= y.Value ? -1 : 1; });

        var notMatched = nums.Count;
        var listCount = new int [nums.Count];
        var result = new int [2] { 0, int.MaxValue };
        var left = 0;
        var right = 0;

        while (right < list.Count)
        {
            while (right < list.Count && notMatched != 0)
            {
                if (listCount[list[right].ListIndex] == 0)
                {
                    notMatched--;
                }

                listCount[list[right].ListIndex]++;
                right++;
            }

            while (notMatched == 0)
            {
                if (list[right - 1].Value - list[left].Value < result[1] - result[0])
                {
                    result = new int [2] { list[left].Value, list[right - 1].Value };
                }

                listCount[list[left].ListIndex]--;
                if (listCount[list[left].ListIndex] == 0)
                {
                    notMatched++;
                }

                left++;
            }
        }

        return result;
    }
}