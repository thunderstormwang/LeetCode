namespace LeetCode.Solution0101_0150;

public class Solution0134
{
    public int CanCompleteCircuit_Brutal(int[] gas, int[] cost)
    {
        for (var start = 0; start < gas.Length; start++)
        {
            var gasLeft = gas[start] - cost[start];
            var i = (start + 1) % gas.Length;
            while (gasLeft >= 0 && i != start)
            {
                gasLeft += gas[i] - cost[i];
                i = (i + 1) % gas.Length;
            }

            if (gasLeft >= 0 && i == start)
            {
                return i;
            }
        }

        return -1;
    }

    public int CanCompleteCircuit_Greedy(int[] gas, int[] cost)
    {
        var currSum = 0;
        var totalSum = 0;
        var index = 0;

        for (var i = 0; i < gas.Length; i++)
        {
            currSum += gas[i] - cost[i];
            totalSum += gas[i] - cost[i];
            if (currSum < 0)
            {
                index = i + 1;
                currSum = 0;
            }
        }

        if (totalSum < 0)
        {
            return -1;
        }

        return index;
    }
}