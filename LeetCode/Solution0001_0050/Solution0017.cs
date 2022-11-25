using System.Text;

namespace LeetCode.Solution0001_0050
{
    public class Solution0017
    {
        private readonly string[][] _letterArray = new string[][]
        {
            new string[] { "a", "b", "c" },
            new string[] { "d", "e", "f" },
            new string[] { "g", "h", "i" },
            new string[] { "j", "k", "l" },
            new string[] { "m", "n", "o" },
            new string[] { "p", "q", "r", "s" },
            new string[] { "t", "u", "v" },
            new string[] { "w", "x", "y", "z" },
        };

        public IList<string> LetterCombinations_Iterative(string digits)
        {
            var result = new List<string>();
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    result = new List<string>(_letterArray[FindIndex(digits[i].ToString())]);
                    continue;
                }

                var tempResult = new List<string>();
                var currentStr = _letterArray[FindIndex(digits[i].ToString())];
                foreach (var item in currentStr)
                {
                    foreach (var preItem in result)
                    {
                        var temp = preItem.Insert(0, item);
                        tempResult.Add(temp);
                    }
                }

                result = tempResult;
            }

            return result;
        }

        public IList<string> LetterCombinations_Recursive(string digits)
        {
            var result = new List<string>();
            if (digits.Length == 0)
            {
                return result;
            }

            FindCombinations(digits, 0, new StringBuilder(), result);

            return result;
        }

        private void FindCombinations(string digits, int index, StringBuilder strBuilder, IList<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(strBuilder.ToString());
                return;
            }

            var currentStr = _letterArray[FindIndex(digits[index].ToString())];

            foreach (var item in currentStr)
            {
                strBuilder.Append(item);
                FindCombinations(digits, index + 1, strBuilder, result);
                strBuilder.Remove(strBuilder.Length - 1, 1);
            }
        }

        private int FindIndex(string input)
        {
            return int.Parse(input) - 2;
        }
    }
}