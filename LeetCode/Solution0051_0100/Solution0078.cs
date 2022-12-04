namespace LeetCode.Solution0051_0100;

public class Solution0078
{
    private int[] _nums;

    public IList<IList<int>> Subsets(int[] nums)
    {
        _nums = nums;
        
        var result = new List<IList<int>>();
        Backtrack(0, new List<int>(), result);

        return result;
    }

    /// <summary>
    /// 走過每個節點皆記錄現在的結果
    /// </summary>
    /// <param name="index"></param>
    /// <param name="curr"></param>
    /// <param name="result"></param>
    private void Backtrack(int index, IList<int> curr, IList<IList<int>> result)
    {
        result.Add(curr.ToArray());

        for (var i = index; i < _nums.Length; i++)
        {
            curr.Add(_nums[i]);
            Backtrack(i + 1, curr, result);
            curr.Remove(_nums[i]);
        }
    }
    
    // Time: O(2^N) -- 每個元素可選或不選
    // Time: O(N) -- 最多遞迴 N 層
}