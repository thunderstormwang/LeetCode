namespace LeetCode.Solution0001_0050;

public class Solution0046
{
    private int[] _nums;
    private bool[] _used;

    public IList<IList<int>> Permute_Iterative(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>() { new List<int>() { nums[0] } };

        for (var i = 1; i < nums.Length; i++)
        {
            IList<IList<int>> stepResult = new List<IList<int>>();
            foreach (var item in result)
            {
                for (var index = 0; index <= item.Count; index++)
                {
                    var temp = new List<int>();
                    temp.AddRange(item);
                    temp.Insert(index, nums[i]);
                    stepResult.Add(temp);
                }
            }

            result = stepResult;
        }

        return result;
    }

    /// <summary>
    /// Time: O(N!) -- N 個元素一共有 N! 種排列
    /// <br/>
    /// <br/>Memory: O(N) -- 最多遞迴 N 層, 加上長度為 N 的陣列記錄被使用過的元素 O(N) + O(N) 仍為 O(N)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute_Recursive(int[] nums)
    {
        _nums = nums;
        _used = new bool [nums.Length];
        var result = new List<IList<int>>();

        Backtrack(new List<int>(), result);

        return result;
    }

    public IList<IList<int>> Permute_RecursiveSwap(int[] nums)
    {
        _nums = nums;
        var result = new List<IList<int>>();

        Backtrack_Swap(0, result);

        return result;
    }

    private void Backtrack(List <int> curr, IList<IList<int>> result)
    {
        if (curr.Count == _nums.Length)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var i = 0; i < _nums.Length; i++)
        {
            if (_used[i])
            {
                continue;
            }
                
            curr.Add(_nums[i]);
            _used[i] = true;
            Backtrack(curr, result);
            curr.RemoveAt(curr.Count-1);
            _used[i] = false;
        }
    }

    private void Backtrack_Swap(int index, IList<IList<int>> result)
    {
        if (index == _nums.Length)
        {
            result.Add(new List<int>(_nums));
            return;
        }

        for (var i = index; i < _nums.Length; i++)
        {
            (_nums[i], _nums[index]) = (_nums[index], _nums[i]);
            Backtrack_Swap(index + 1, result);
            (_nums[i], _nums[index]) = (_nums[index], _nums[i]);
        }
    }
}