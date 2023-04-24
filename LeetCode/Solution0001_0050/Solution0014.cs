using System.Text;

namespace LeetCode.Solution0001_0050;

public class Solution0014
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        var result = new StringBuilder();

        for (var i = 0; i < strs[0].Length; i++)
        {
            var temp = strs[0][i];
            for (var j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length - 1 < i || temp != strs[j][i])
                {
                    return result.ToString();
                }
            }

            result.Append(temp);
        }

        return result.ToString();
    }
}