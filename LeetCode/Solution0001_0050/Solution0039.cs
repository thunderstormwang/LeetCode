namespace LeetCode.Solution0001_0050
{
    public class Solution0039
    {
        private int[] _candidates;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _candidates = candidates;
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

            for (var i = startIndex; i < _candidates.Length; i++)
            {
                if (target < _candidates[i])
                {
                    continue;
                }

                curr.Add(_candidates[i]);
                FindCombinationSum(target - _candidates[i], i, curr, result);
                curr.Remove(_candidates[i]);
            }
        }
        
        // 因為陣列每個元素都是唯一, 在每次遞迴中不用擔心在 i 和 i+1 挑到相同元素而計算出相同組合  
    }
}