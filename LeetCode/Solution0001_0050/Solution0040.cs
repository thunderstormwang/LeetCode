namespace LeetCode.Solution0001_0050
{
    public class Solution0040
    {
        private int[] _candidates;
        
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            _candidates = candidates;
            Array.Sort(candidates);
            
            var result = new List<IList<int>>();
            FindCombinationSum(target, 0, new List<int>(), result);
            return result;
        }

        private void FindCombinationSum(int target, int startIndex, IList<int> curr, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(curr.ToArray());
                return;
            }

            for (var i = startIndex; i < _candidates.Length && _candidates[i] <= target; i++)
            {
                if (i > startIndex && _candidates[i] == _candidates[i - 1])
                {
                    continue;
                }

                curr.Add(_candidates[i]);
                FindCombinationSum(target - _candidates[i], i + 1, curr, result);
                curr.RemoveAt(curr.Count - 1);
            }
        }

        // 因為陣列每個元素不是唯一, 在每次遞迴中要注意不能挑到相同的元素, 不然會計算出相同組合
        // ex: 2, 2, 2, 5, target = 7

        // Time: O(2^N) -- 排序 O(N * logN), 
        // 每個元素可以選或不選, 總共有 2^N 種組合, 所以是 O(2^N)
        // 兩者相加後是 O(2^N)
        // Space: O(N) -- 最多遞迴 N 層
    }
}