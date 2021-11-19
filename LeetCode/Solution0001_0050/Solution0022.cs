using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0001_0050
{
    public class Solution0022
    {
        private readonly int[] _parenthesisCandidate = new int[2]
        {
            1, -1
        };

        public IList<string> GenerateParenthesis_Approach1(int n)
        {
            var result = new List<string>();
            FindCombination_PutAndCheck(new int[n * 2],
                0,
                result);

            return result;
        }

        private void FindCombination_PutAndCheck(int[] parenthesisArray,
            int index,
            List<string> result)
        {
            if (index == parenthesisArray.Length)
            {
                var temp = string.Join(string.Empty,
                    parenthesisArray.Select(p => p == 1 ? "(" : ")"));
                result.Add(temp);

                return;
            }

            foreach (var item in _parenthesisCandidate)
            {
                parenthesisArray[index] = item;
                if (!Check(parenthesisArray,
                    index))
                {
                    continue;
                }

                FindCombination_PutAndCheck(parenthesisArray,
                    index + 1,
                    result);
            }
        }

        private bool Check(int[] parenthesisArray,
            int index)
        {
            var sum = 0;
            var upperLimit = parenthesisArray.Length / 2;

            if (parenthesisArray.Where(p => p > 0).Sum() > upperLimit)
            {
                return false;
            }

            for (var i = 0; i <= index; i++)
            {
                sum += parenthesisArray[i];
                if (sum < 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Time: O(2*N)
        // Space: ??

        public IList<string> GenerateParenthesis_Approach2(int n)
        {
            var result = new List<string>();
            FindCombination_AlwaysPutValid(new int[n * 2],
                0,
                n,
                0,
                result);

            return result;
        }

        private void FindCombination_AlwaysPutValid(int[] parenthesisArray,
            int index,
            int open,
            int close,
            List<string> result)
        {
            if (index == parenthesisArray.Length)
            {
                var temp = string.Join(string.Empty,
                    parenthesisArray.Select(p => p == 1 ? "(" : ")"));
                result.Add(temp);

                return;
            }

            if (open > 0)
            {
                parenthesisArray[index] = 1;
                FindCombination_AlwaysPutValid(parenthesisArray,
                    index + 1,
                    open - 1,
                    close + 1,
                    result);
            }

            if (close > 0)
            {
                parenthesisArray[index] = -1;
                FindCombination_AlwaysPutValid(parenthesisArray,
                    index + 1,
                    open,
                    close - 1,
                    result);
            }
        }
    }
}