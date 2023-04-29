using System.Text;

namespace LeetCode.Solution0201_0300;

public class Solution0271
{
    public string Encode(List<string> strs)
    {
        var sBuilder = new StringBuilder();

        for (var i = 0; i < strs.Count; i++)
        {
            sBuilder.Append(strs[i].Length);
            sBuilder.Append("#");
            sBuilder.Append(strs[i]);
        }

        return sBuilder.ToString();
    }

    public List<string> Decode(string str)
    {
        var lastIndex = 0;
        var i = 0;
        var result = new List<string>();

        while (i < str.Length)
        {
            while (str[i] != '#')
            {
                i++;
            }

            var lengthStr = str.Substring(lastIndex, i - lastIndex);
            var length = int.Parse(lengthStr);

            lastIndex = i + 1;
            var data = str.Substring(lastIndex, length);
            result.Add(data);

            lastIndex += length;
            i = lastIndex;
        }

        return result;
    }
}