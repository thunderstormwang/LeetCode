using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution0022
    {
        private readonly int[] _parenthesisCandidate = new int[2]
        {
            1, -1
        };

        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            var parenthesisArray = new int[n * 2];

            FindCombination(parenthesisArray,
                0,
                result);
            return result;
        }

        private void FindCombination(int[] parenthesisArray,
            int index,
            List<string> result)
        {
            if (index == parenthesisArray.Length - 1)
            {
                foreach (var item in _parenthesisCandidate)
                {
                    parenthesisArray[index] = item;
                    if (!Check(parenthesisArray,
                        index))
                    {
                        continue;
                    }

                    var temp = string.Join(string.Empty,
                        parenthesisArray.Select(p => p == 1 ? "(" : ")"));
                    result.Add(temp);
                }

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
                
                FindCombination(parenthesisArray,
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
    }
}