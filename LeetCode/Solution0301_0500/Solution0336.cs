namespace LeetCode.Solution0301_0500;

public class Solution0336
{
    public IList<IList<int>> PalindromePairs(string[] words)
    {
        var result = new List<IList<int>>();
        var dict = new Dictionary<string, int>();
        var hastSet = new HashSet<int>();
        for (var i = 0; i < words.Length; i++)
        {
            dict.Add(words[i], i);
            hastSet.Add(words[i].Length);
        }

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            if (IsPalindrome(word))
            {
                if (dict.ContainsKey(string.Empty) && dict[string.Empty] != i)
                {
                    result.Add(new List<int>() { i, dict[string.Empty] });
                    result.Add(new List<int>() { dict[string.Empty], i });
                }
            }

            var reverse = new string(word.Reverse().ToArray());
            if (dict.ContainsKey(reverse) && dict[reverse] != i)
            {
                result.Add(new List<int>() { i, dict[reverse] });
            }

            for (var k = 1; k < word.Length; k++)
            {
                var left = word.Substring(0, k);
                var right = word.Substring(k);

                if (hastSet.Contains(left.Length) && IsPalindrome(right))
                {
                    var reverseLeft = new string(left.Reverse().ToArray());
                    if (dict.ContainsKey(reverseLeft) && dict[reverseLeft] != i)
                    {
                        result.Add(new List<int>() { i, dict[reverseLeft] });
                    }
                }

                if (hastSet.Contains(right.Length) && IsPalindrome(left))
                {
                    var reverseRight = new string(right.Reverse().ToArray());
                    if (dict.ContainsKey(reverseRight) && dict[reverseRight] != i)
                    {
                        result.Add(new List<int>() { dict[reverseRight], i });
                    }
                }
            }
        }

        return result;
    }

    private bool IsPalindrome(string str)
    {
        var left = 0;
        var right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}