namespace LeetCode.Solution0001_0050;

public class Solution0049
{
    public IList<IList<string>> GroupAnagrams_Ver1(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();
        var result = new List<IList<string>>();

        for (var i = 0; i < strs.Length; i++)
        {
            var tempArray = strs[i].ToArray();
            Array.Sort(tempArray);
            var temp = new String(tempArray);
            if (!dict.ContainsKey(temp))
            {
                var list = new List<string>();
                dict.Add(temp, list);
                result.Add(list);
            }

            dict[temp].Add(strs[i]);
        }

        return result;
    }

    public IList<IList<string>> GroupAnagrams_Ver2(string[] strs)
    {
        return strs.GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
            .Select(g => g.ToList() as IList<string>)
            .ToList();
    }
}