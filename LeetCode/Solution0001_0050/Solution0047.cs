namespace LeetCode.Solution0001_0050;

public class Solution0047
{
    private int[] _nums;
    private bool[] _used;

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        _nums = nums;
        _used = new bool[nums.Length];
        var result = new List<IList<int>>();
            
        Backtrack(new List<int>(), result);

        return result;
    }

    public IList<IList<int>> PermuteUnique_Swap(int[] nums)
    {
        _nums = nums;
        var result = new List<IList<int>>();

        Backtrack_Swap(0, result);

        return result;
    }

    private void Backtrack(List<int> curr, IList<IList<int>> result)
    {
        if (curr.Count == _nums.Length)
        {
            result.Add(curr.ToArray());
        }

        var usedByCurrLevel = new HashSet<int>();

        for (var i = 0; i < _nums.Length; i++)
        {
            if (_used[i] || usedByCurrLevel.Contains(_nums[i]))
            {
                continue;
            }
                
            curr.Add(_nums[i]);
            _used[i] = true;
            Backtrack(curr, result);
            curr.RemoveAt(curr.Count -1);
            _used[i] = false;
            usedByCurrLevel.Add(_nums[i]);
        }
    }

    private void Backtrack_Swap(int index, IList<IList<int>> result)
    {
        if (index == _nums.Length)
        {
            result.Add(new List<int>(_nums));
        }

        var usedByCurrLevel = new HashSet<int>();

        for (var i = index; i < _nums.Length; i++)
        {
            if (!usedByCurrLevel.Add(_nums[i]))
            {
                continue;
            }

            (_nums[i], _nums[index]) = (_nums[index], _nums[i]);
            Backtrack_Swap(index + 1, result);
            (_nums[i], _nums[index]) = (_nums[index], _nums[i]);
        }
    }
}