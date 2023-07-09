using System.Text;

namespace LeetCode.Solution0001_0050;

public class Solution0022
{
    public IList<string> GenerateParenthesis_Ver1(int n)
    {
        var result = new List<string>();

        Backtrack_Ver1(n, 0, new StringBuilder(), result);

        return result;
    }

    private void Backtrack_Ver1(int n, int left, StringBuilder curr, IList<string> result)
    {
        if (curr.Length == 2 * n)
        {
            result.Add(curr.ToString());
        }

        if (left < n)
        {
            curr.Append('(');
            Backtrack_Ver1(n, left + 1, curr, result);
            curr.Remove(curr.Length - 1, 1);
        }

        var right = curr.Length - left;
        if (right < left)
        {
            curr.Append(')');
            Backtrack_Ver1(n, left, curr, result);
            curr.Remove(curr.Length - 1, 1);
        }
    }

    public IList<string> GenerateParenthesis_Ver2(int n)
    {
        var result = new List<string>();
        Backtrack_Ver2(new int[n * 2], 0, n, 0, result);

        return result;
    }

    private void Backtrack_Ver2(int[] parenthesisArray, int index, int open, int close, List<string> result)
    {
        if (index == parenthesisArray.Length)
        {
            var temp = string.Join(string.Empty, parenthesisArray.Select(p => p == 1 ? "(" : ")"));
            result.Add(temp);

            return;
        }

        if (open > 0)
        {
            parenthesisArray[index] = 1;
            Backtrack_Ver2(parenthesisArray, index + 1, open - 1, close + 1, result);
        }

        if (close > 0)
        {
            parenthesisArray[index] = -1;
            Backtrack_Ver2(parenthesisArray, index + 1, open, close - 1, result);
        }
    }

    public IList<string> GenerateParenthesis_Ver3(int n)
    {
        var result = new List<string>();
        var candidates = new int[] { 1, -1 };
        Backtrack_Ver3(new int[n * 2], 0, candidates, result);

        return result;
    }

    private void Backtrack_Ver3(int[] parenthesisArray, int index, int[] candidates, List<string> result)
    {
        if (index == parenthesisArray.Length)
        {
            var temp = string.Join(string.Empty, parenthesisArray.Select(p => p == 1 ? "(" : ")"));
            result.Add(temp);

            return;
        }

        foreach (var item in candidates)
        {
            parenthesisArray[index] = item;
            if (!Check(parenthesisArray, index))
            {
                continue;
            }

            Backtrack_Ver3(parenthesisArray, index + 1, candidates, result);
        }
    }

    private bool Check(int[] parenthesisArray, int index)
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
}