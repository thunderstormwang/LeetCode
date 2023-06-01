namespace LeetCode.Solution0501_9999;

public class Solution0721
{
    public IList<IList<string>> AccountsMerge_Ver1(IList<IList<string>> accounts)
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
            item.Value.Sort((x, y) => { return string.CompareOrdinal(x, y); });
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

    public IList<IList<string>> AccountsMerge_Ver2(IList<IList<string>> accounts)
    {
        var result = new List<IList<string>>();
        var emailAccountDict = new Dictionary<string, List<int>>();

        for (var i = 0; i < accounts.Count; i++)
        {
            for (var j = 1; j < accounts[i].Count; j++)
            {
                if (!emailAccountDict.ContainsKey(accounts[i][j]))
                {
                    emailAccountDict.Add(accounts[i][j], new List<int>());
                }

                emailAccountDict[accounts[i][j]].Add(i);
            }
        }

        var queue = new Queue<int>();
        var visited = new int [accounts.Count];

        for (var cnt = 0; cnt < accounts.Count; cnt++)
        {
            if (visited[cnt] == 1)
            {
                continue;
            }

            queue.Enqueue(cnt);
            var hashSet = new HashSet<string>();
            visited[cnt] = 1;

            while (queue.Count != 0)
            {
                var i = queue.Dequeue();
                visited[i] = 1;

                for (var j = 1; j < accounts[i].Count; j++)
                {
                    var email = accounts[i][j];
                    hashSet.Add(email);

                    for (var accountIndex = 0; accountIndex < emailAccountDict[email].Count; accountIndex++)
                    {
                        if (visited[emailAccountDict[email][accountIndex]] == 1)
                        {
                            continue;
                        }

                        queue.Enqueue(emailAccountDict[email][accountIndex]);
                    }
                }
            }

            var list = new List<string>(hashSet);
            list.Sort((x, y) => { return string.CompareOrdinal(x, y); });
            list.Insert(0, accounts[cnt][0]);
            result.Add(list);
        }

        return result;
    }
}