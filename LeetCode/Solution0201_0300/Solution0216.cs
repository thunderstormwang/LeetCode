namespace LeetCode.Solution0201_0300;

public class Solution0216
{
    private int[] _array;
    private int _targetSum;
    private int _k;

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        _k = k;
        _array = Enumerable.Range(1, 9).ToArray();
        _targetSum = n;

        IList<IList<int>> result = new List<IList<int>>();
        Backtrack(new List<int>(), 0, result);

        return result;
    }

    private void Backtrack(List<int> curr, int index, IList<IList<int>> result)
    {
        if (curr.Count == _k)
        {
            if (curr.Sum() == _targetSum)
            {
                result.Add(curr.ToArray());
            }
            return;
        }
        
        if (curr.Sum() >= _targetSum)
        {
            return;
        }

        // 此處的終止條件可參考 77 是如何推導出來的
        for (var i = index; i <= _array.Length - (_k - curr.Count); i++)
        {
            curr.Add(_array[i]);
            Backtrack(curr, i + 1, result);
            curr.Remove(_array[i]);
        }
    }
    
    // Time: O(C(9,k)) -- 每個組合都要走一遍 
    // Space: O(k) -- 最多到遞迴到 k 層
}