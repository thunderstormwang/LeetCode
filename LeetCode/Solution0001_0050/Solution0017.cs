using System.Text;

namespace LeetCode.Solution0001_0050;

public class Solution0017
{
    /// <summary>
    /// Recursive
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public IList<string> LetterCombinations_Ver1(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }

        var result = new List<string>();
        var dict = new Dictionary<char, string[]>()
        {
            { '2', new string[] { "a", "b", "c" } },
            { '3', new string[] { "d", "e", "f" } },
            { '4', new string[] { "g", "h", "i" } },
            { '5', new string[] { "j", "k", "l" } },
            { '6', new string[] { "m", "n", "o" } },
            { '7', new string[] { "p", "q", "r", "s" } },
            { '8', new string[] { "t", "u", "v" } },
            { '9', new string[] { "w", "x", "y", "z" } }
        };
        Backtrack(digits, dict, 0, new StringBuilder(), result);

        return result;
    }

    /// <summary>
    /// Iterative
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public IList<string> LetterCombinations_Ver2(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }

        var result = new List<string>() { string.Empty };
        var dict = new Dictionary<char, string[]>()
        {
            { '2', new string[] { "a", "b", "c" } },
            { '3', new string[] { "d", "e", "f" } },
            { '4', new string[] { "g", "h", "i" } },
            { '5', new string[] { "j", "k", "l" } },
            { '6', new string[] { "m", "n", "o" } },
            { '7', new string[] { "p", "q", "r", "s" } },
            { '8', new string[] { "t", "u", "v" } },
            { '9', new string[] { "w", "x", "y", "z" } }
        };
        var index = 0;

        while (index < digits.Length)
        {
            var candidates = dict[digits[index]];
            var temp = new List<string>();

            for (var i = 0; i < result.Count; i++)
            {
                var target = result[i];
                for (var j = 0; j < candidates.Length; j++)
                {
                    temp.Add(target + candidates[j]);
                }
            }

            result = temp;
            index++;
        }

        return result;
    }

    private void Backtrack(string digits, Dictionary<char, string[]> dict, int index, StringBuilder strBuilder, IList<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(strBuilder.ToString());
            return;
        }

        var candidates = dict[digits[index]];

        foreach (var item in candidates)
        {
            strBuilder.Append(item);
            Backtrack(digits, dict, index + 1, strBuilder, result);
            strBuilder.Remove(strBuilder.Length - 1, 1);
        }
    }
}