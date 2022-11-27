namespace LeetCode.Solution0051_0100;

public class Solution0077
{
    private int[] _array;
    private int _k;
    
    public IList<IList<int>> Combine(int n, int k)
    {
        _array = Enumerable.Range(1, n).ToArray();
        _k = k;

        var result = new List<IList<int>>();
        Backtrack(0, new List<int>(), result);

        return result;
    }

    private void Backtrack(int index, List<int> curr, List<IList<int>> result)
    {
        if (curr.Count == _k)
        {
            result.Add(curr.ToArray());
            return;
        }

        // 剩餘元素不夠使用, 立即結束
        // i < array.Length && _k - curr.Count <= _array.Length - i
        // 移項 => i < array.Length && i <= _array.Length - (_k - curr.Count)
        // 兩者可合併 => i <= _array.Length - (_k - curr.Count)
        
        for (var i = index; i <= _array.Length - (_k - curr.Count); i++)
        {
            curr.Add(_array[i]);
            Backtrack(i + 1, curr, result);
            curr.Remove(_array[i]);
        }
    }
    
    // Time: O(C(n,k)) -- 每個組合都要走一遍 
    // Space: O(k) -- 最多到遞迴到 k 層
}