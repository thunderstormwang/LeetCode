namespace LeetCode.Solution0051_0100;

public class Solution0090
{
    private int[] _nums;

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        _nums = nums;

        Array.Sort(nums);
        var result = new List<IList<int>>();
        Backtrack(0, new List<int>(), result);

        return result;
    }

    private void Backtrack(int index, IList<int> curr, IList<IList<int>> result)
    {
        result.Add(curr.ToArray());

        for (var i = index; i < _nums.Length; i++)
        {
            if (i > index && i < _nums.Length && _nums[i - 1] == _nums[i])
            {
                continue;
            }

            curr.Add(_nums[i]);
            Backtrack(i + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }
        
    // 因為陣列每個元素不是唯一, 在每次遞迴中要注意不能挑到相同的元素, 不然會計算出相同組合
    // ex: 2, 2

    // Time: O(2^N) -- 排序 O(N * logN), 
    // 每個元素可以選或不選, 總共有 2^N 種組合, 所以是 O(2^N)
    // 兩者相加後是 O(2^N)
    // Space: O(N) -- 最多遞迴 N 層
}