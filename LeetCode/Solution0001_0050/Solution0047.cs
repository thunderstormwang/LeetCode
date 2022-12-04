namespace LeetCode.Solution0001_0050;

public class Solution0047
{
    private int[] _nums;
    private bool[] _used;

    /// <summary>
    /// Time: O(N!) -- N 個元素, 假設都不重覆, 一共有 N! 種排列
    /// <br/>因為已是 O(N!), 那也可以先對輸入的陣列 nums 做排序, 那就不需要記錄每層使用過的元素 usedByCurrLevel,
    /// 也不影嚮複雜度的計算
    /// <br/>
    /// <br/>Memory: O(N) -- 最多遞迴 N 層, 加上長度為 N 的陣列記錄被使用過的元素 O(N) + O(N) 仍為 O(N)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
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