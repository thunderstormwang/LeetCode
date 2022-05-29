namespace LeetCode
{
    public class Solution0229
    {
        public IList<int> MajorityElement(int[] nums)
        {
            var candidates = new int [2];
            var votes = new int [2];

            foreach (var item in nums)
            {
                if (candidates[0] == item)
                {
                    votes[0]++;
                }
                else if (candidates[1] == item)
                {
                    votes[1]++;
                }

                else if (votes[0] == 0)
                {
                    candidates[0] = item;
                    votes[0] = 1;
                }
                else if (votes[1] == 0)
                {
                    candidates[1] = item;
                    votes[1] = 1;
                }
                else
                {
                    votes[0]--;
                    votes[1]--;
                }
            }

            votes[0] = 0;
            votes[1] = 0;
            foreach (var item in nums)
            {
                votes[0] += candidates[0] == item ? 1 : 0;
                votes[1] += candidates[1] == item ? 1 : 0;
            }

            var result = new List<int>();
            if (votes[0] > nums.Length / 3)
            {
                result.Add(candidates[0]);
            }

            if (candidates[0] != candidates[1] && votes[1] > nums.Length / 3)
            {
                result.Add(candidates[1]);
            }

            return result;
        }
    }
}