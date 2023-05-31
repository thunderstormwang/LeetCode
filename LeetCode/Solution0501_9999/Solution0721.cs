namespace LeetCode.Solution0501_9999;

public class Solution0721
{
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var root = new Dictionary<string, string>();
        var owner = new Dictionary<string, string>();
        var mergeAccounts = new Dictionary<string, List<string>>();
        var result = new List<IList<string>>();

        for (var i = 0; i < accounts.Count; i++)
        {
            for (var j = 1; j < accounts[i].Count; j++)
            {
                if (!root.ContainsKey(accounts[i][j]))
                {
                    root.Add(accounts[i][j], accounts[i][j]);
                }

                if (!owner.ContainsKey(accounts[i][j]))
                {
                    owner.Add(accounts[i][j], accounts[i][0]);
                }
            }
        }

        for (var i = 0; i < accounts.Count; i++)
        {
            var parent = Find(accounts[i][1], root);

            for (var j = 2; j < accounts[i].Count; j++)
            {
                root[Find(accounts[i][j], root)] = parent;
            }
        }

        foreach (var item in root)
        {
            var parent = Find(item.Key, root);

            if (!mergeAccounts.ContainsKey(parent))
            {
                mergeAccounts.Add(parent, new List<string>());
            }

            mergeAccounts[parent].Add(item.Key);
        }

        foreach (var item in mergeAccounts)
        {
            item.Value.Sort((x, y) =>
            {
                return string.CompareOrdinal(x, y);
            });
            var list = new List<string>() { owner[item.Key] };
            list.AddRange(item.Value);
            result.Add(list);
        }

        return result;
    }

    private string Find(string child, Dictionary<string, string> root)
    {
        return root[child] == child ? child : Find(root[child], root);
    }
}