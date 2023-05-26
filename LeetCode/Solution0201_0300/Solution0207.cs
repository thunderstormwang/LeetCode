namespace LeetCode.Solution0201_0300;

public class Solution0207
{
    /// <summary>
    /// Topological Sort
    /// </summary>
    /// <param name="numCourses"></param>
    /// <param name="prerequisites"></param>
    /// <returns></returns>
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var adjacentList = new List<List<int>>();

        for (var i = 0; i < numCourses; i++)
        {
            adjacentList.Add(new List<int>());
        }

        for (var i = 0; i < prerequisites.Length; i++)
        {
            adjacentList[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        var visit = new int [numCourses];

        for (var i = 0; i < numCourses; i++)
        {
            if (HasCycle(i, visit, adjacentList))
            {
                return false;
            }
        }

        return true;
    }

    private bool HasCycle(int node, int[] visit, List<List<int>> adjacentList)
    {
        if (visit[node] == 1)
        {
            return true;
        }

        if (visit[node] == 2)
        {
            return false;
        }

        visit[node] = 1;

        for (var i = 0; i < adjacentList[node].Count; i++)
        {
            if (HasCycle(adjacentList[node][i], visit, adjacentList))
            {
                return true;
            }
        }

        visit[node] = 2;

        return false;
    }

    /// <summary>
    /// Depth First Search
    /// </summary>
    /// <param name="numCourses"></param>
    /// <param name="prerequisites"></param>
    /// <returns></returns>
    public bool CanFinish_Ver2(int numCourses, int[][] prerequisites)
    {
        var adjacentList = new List<List<int>>();

        for (var i = 0; i < numCourses; i++)
        {
            adjacentList.Add(new List<int>());
        }

        for (var i = 0; i < prerequisites.Length; i++)
        {
            adjacentList[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        for (var i = 0; i < numCourses; i++)
        {
            var visit = new bool [numCourses];
            if (Recursive_DFS(i, i, visit, adjacentList))
            {
                return false;
            }
        }

        return true;
    }

    private bool Recursive_DFS(int start, int curr, bool[] visit, List<List<int>> adjacentList)
    {
        // 如果回到原點, 代表有循環
        if (start == curr && visit[curr])
        {
            return true;
        }

        if (visit[curr])
        {
            return false;
        }

        visit[curr] = true;

        for (var i = 0; i < adjacentList[curr].Count; i++)
        {
            if (Recursive_DFS(start, adjacentList[curr][i], visit, adjacentList))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Breadth First Search
    /// </summary>
    /// <param name="numCourses"></param>
    /// <param name="prerequisites"></param>
    /// <returns></returns>
    public bool CanFinish_Ver3(int numCourses, int[][] prerequisites)
    {
        var adjacentList = new List<List<int>>();
        var inDegree = new int[numCourses];
        var traverseNode = 0;
        var queue = new Queue<int>();

        for (var i = 0; i < numCourses; i++)
        {
            adjacentList.Add(new List<int>());
        }

        for (var i = 0; i < prerequisites.Length; i++)
        {
            adjacentList[prerequisites[i][1]].Add(prerequisites[i][0]);
            inDegree[prerequisites[i][0]]++;
        }

        for (var i = 0; i < inDegree.Length; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            traverseNode++;

            for (var i = 0; i < adjacentList[node].Count; i++)
            {
                inDegree[adjacentList[node][i]]--;
                if (inDegree[adjacentList[node][i]] == 0)
                {
                    queue.Enqueue(adjacentList[node][i]);
                }
            }
        }

        return traverseNode == numCourses;
    }
}