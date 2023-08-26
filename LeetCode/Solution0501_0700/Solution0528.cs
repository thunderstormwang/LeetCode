namespace LeetCode.Solution0501_0700;

public class Solution0528
{
    private readonly int[] _cumulativeSum;
    private readonly Random _rand = new Random(Guid.NewGuid().GetHashCode());

    public Solution0528(int[] w)
    {
        _cumulativeSum = new int [w.Length];
        _cumulativeSum[0] = w[0];

        for (var i = 1; i < w.Length; i++)
        {
            _cumulativeSum[i] = _cumulativeSum[i - 1] + w[i];
        }
    }

    public int PickIndex()
    {
        var target = _rand.Next(1, _cumulativeSum[_cumulativeSum.Length - 1] + 1);
        var left = 0;
        var right = _cumulativeSum.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;

            if (_cumulativeSum[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return right;
    }
}