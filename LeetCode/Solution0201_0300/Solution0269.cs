using System.Text;

namespace LeetCode.Solution0201_0300;

public class Solution0269
{
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public string AlienOrder_Ver1(string[] words)
    {
        var graph = new Dictionary<char, List<char>>();
        var queue = new Queue<char>();
        var result = new StringBuilder();
        var inDegrees = new Dictionary<char, int>();

        for (var i = 0; i < words.Length; i++)
        {
            for (var j = 0; j < words[i].Length; j++)
            {
                if (!graph.ContainsKey(words[i][j]))
                {
                    graph.Add(words[i][j], new List<char>());
                }

                if (!inDegrees.ContainsKey(words[i][j]))
                {
                    inDegrees.Add(words[i][j], 0);
                }
            }
        }

        for (var i = 0; i < words.Length - 1; i++)
        {
            var minLength = Math.Min(words[i].Length, words[i + 1].Length);

            for (var j = 0; j < minLength; j++)
            {
                if (words[i][j] == words[i + 1][j])
                {
                    continue;
                }

                if (!graph[words[i][j]].Contains(words[i + 1][j]))
                {
                    graph[words[i][j]].Add(words[i + 1][j]);
                    inDegrees[words[i + 1][j]]++;
                    break;
                }
            }
        }

        foreach (var item in inDegrees)
        {
            if (item.Value == 0)
            {
                queue.Enqueue(item.Key);
            }
        }

        var count = 0;

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            count++;
            result.Append(node);

            for (var i = 0; i < graph[node].Count; i++)
            {
                inDegrees[graph[node][i]]--;
                if (inDegrees[graph[node][i]] == 0)
                {
                    queue.Enqueue(graph[node][i]);
                }
            }
        }

        return count == graph.Count ? result.ToString() : string.Empty;
    }

    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public string AlienOrder_Ver2(string[] words)
    {
        var graph = new Dictionary<char, List<char>>();
        var visited = new Dictionary<char, int>();
        var result = new StringBuilder();

        for (var i = 0; i < words.Length; i++)
        {
            for (var j = 0; j < words[i].Length; j++)
            {
                if (!graph.ContainsKey(words[i][j]))
                {
                    graph.Add(words[i][j], new List<char>());
                }

                if (!visited.ContainsKey(words[i][j]))
                {
                    visited.Add(words[i][j], 0);
                }
            }
        }

        for (var i = 0; i < words.Length - 1; i++)
        {
            var minLength = Math.Min(words[i].Length, words[i + 1].Length);

            for (var j = 0; j < minLength; j++)
            {
                if (words[i][j] == words[i + 1][j])
                {
                    continue;
                }

                if (!graph[words[i][j]].Contains(words[i + 1][j]))
                {
                    graph[words[i][j]].Add(words[i + 1][j]);
                }
            }
        }

        foreach (var item in visited)
        {
            if (item.Value != 0)
            {
                continue;
            }

            if (!DepthFirstSearch(item.Key, graph, visited, result))
            {
                return string.Empty;
            }
        }
        
        return new string(result.ToString().Reverse().ToArray());
    }

    private bool DepthFirstSearch(char curr, Dictionary<char, List<char>> graph, Dictionary<char, int> visited, StringBuilder result)
    {
        if (visited[curr] == 1)
        {
            return false;
        }

        if (visited[curr] == 2)
        {
            return true;
        }

        visited[curr] = 1;

        for (var i = 0; i < graph[curr].Count; i++)
        {
            if (!DepthFirstSearch(graph[curr][i], graph, visited, result))
            {
                return false;
            }
        }

        result.Append(curr);

        visited[curr] = 2;

        return true;
    }
}