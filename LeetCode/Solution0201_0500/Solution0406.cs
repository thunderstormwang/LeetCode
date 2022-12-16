namespace LeetCode.Solution0201_0500;

public class Solution0406
{
    public int[][] ReconstructQueue(int[][] people)
    {
        Array.Sort(people, (x, y) =>
        {
            if (x[0] < y[0])
            {
                return 1;
            }

            if (x[0] > y[0])
            {
                return -1;
            }

            if (x[1] > y[1])
            {
                return 1;
            }

            if (x[1] < y[1])
            {
                return -1;
            }

            return 0;
        });

        var result = new List<int[]>();
        foreach (var item in people)
        {
            result.Insert(item[1], item);
        }

        return result.ToArray();
    }
}