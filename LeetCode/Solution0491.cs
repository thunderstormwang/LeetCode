namespace LeetCode
{
    public class Solution0491
    {
        private int[] _nums;
        
        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            _nums = nums;
            
            var result = new List<IList<int>>();
            Backtrack(0, new List<int>(), result);

            return result;
        }
        
        // 新寫版本
        private void Backtrack(int index, IList<int> curr, IList<IList<int>> result)
        {
            var used = new HashSet<int>();
            
            if (curr.Count >= 2)
            {
                result.Add(curr.ToArray());
            }

            if (index == _nums.Length)
            {
                return;
            }
            
            //Backtrack(index + 1, curr, result);
            
            for (var i = index; i < _nums.Length; i++)
            {
                if (curr.Count != 0 && curr.Last() > _nums[i])
                {
                    continue;
                }

                if (used.Contains(_nums[i]))
                {
                    continue;
                }

                curr.Add(_nums[i]);
                Backtrack(i + 1, curr, result);
                curr.RemoveAt(curr.Count - 1);
                used.Add(_nums[i]);
            }
        }

        // 舊版本
        // private void Backtrack(int index, IList<int> curr, IList<IList<int>> result)
        // {
        //     var notInChoice = new HashSet<int>();
        //     for (var i = index; i < _nums.Length; i++)
        //     {
        //         if (curr.Count != 0 && curr.Last() > _nums[i])
        //         {
        //             continue;
        //         }
        //
        //         if (notInChoice.Contains(_nums[i]))
        //         {
        //             continue;
        //         }
        //
        //         curr.Add(_nums[i]);
        //         if (curr.Count >= 2)
        //         {
        //             result.Add(curr.ToArray());
        //         }
        //
        //         Backtrack(i + 1, curr, result);
        //         curr.RemoveAt(curr.Count - 1);
        //         notInChoice.Add(_nums[i]);
        //     }
        // }
    }
}