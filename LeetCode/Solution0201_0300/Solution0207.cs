namespace LeetCode.Solution0201_0300;

public class Solution0207
{
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
            if (Cycle(i, visit, adjacentList))
            {
                return false;
            }
        }

        return true;
    }

    private bool Cycle(int node, int[] visit, List<List<int>> adjacentList)
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
            if (Cycle(adjacentList[node][i], visit, adjacentList))
            {
                return true;
            }
        }

        visit[node] = 2;

        return false;
    }

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
            if (DFS(i, i, visit, adjacentList))
            {
                return false;
            }
        }

        return true;
    }

    private bool DFS(int start, int curr, bool[] visit, List<List<int>> adjacentList)
    {
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
            if (DFS(start, adjacentList[curr][i], visit, adjacentList))
            {
                return true;
            }
        }

        return false;
    }
}