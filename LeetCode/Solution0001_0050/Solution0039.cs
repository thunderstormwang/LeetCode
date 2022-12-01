namespace LeetCode.Solution0001_0050
{
    public class Solution0039
    {
        private int[] _candidates;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _candidates = candidates;
            
            var result = new List<IList<int>>();
            Backtrack(target, 0, new List<int>(), result);
            return result;
        }

        private void Backtrack(int target, int startIndex, IList<int> curr, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(curr.ToArray());
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (var i = startIndex; i < _candidates.Length; i++)
            {
                curr.Add(_candidates[i]);
                Backtrack(target - _candidates[i], i, curr, result);
                curr.Remove(_candidates[i]);
            }
        }
        
        // 因為陣列每個元素都是唯一, 在每次遞迴中不用擔心在 i 和 i+1 挑到相同元素而計算出相同組合
        
        // Time: O(2^N)
        // int[] arr = {2, 3, 4, 5, 6}, target = 10, 因為每個元素可以重覆利用
        // 那麼 arr 可以擴展成 {2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6}, 數量變成 N' 個
        // 每個元素可以選或不選, 所以所有的組合有 2^(N') 個, 可視作 2^N
        // Time: O(N)
        // 同上, arr 擴展後, 如果每個元素都選, 最多遞迴至 N' 層, 可視作 N 
    }
}