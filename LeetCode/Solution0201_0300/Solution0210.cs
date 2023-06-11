namespace LeetCode.Solution0201_0300;

public class Solution0210
{
    /// <summary>
    /// Topological Sort - DFS
    /// </summary>
    /// <param name="numCourses"></param>
    /// <param name="prerequisites"></param>
    /// <returns></returns>
    public int[] FindOrder_Ver1(int numCourses, int[][] prerequisites)
    {
        var stack = new Stack<int>();
        var result = new List<int>();
        var visited = new int [numCourses];
        var adjacentList = new Dictionary<int, List<int>>();

        for (var i = 0; i < numCourses; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for (var i = 0; i < prerequisites.Length; i++)
        {
            adjacentList[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        for (var i = 0; i < numCourses; i++)
        {
            if (DepthFirstSearch(i, adjacentList, visited, stack))
            {
                return Array.Empty<int>();
            }
        }

        while (stack.Count != 0)
        {
            result.Add(stack.Pop());
        }

        return result.ToArray();
    }
    
    /// <summary>
    /// Topological Sort - BFS
    /// </summary>
    /// <param name="numCourses"></param>
    /// <param name="prerequisites"></param>
    /// <returns></returns>
    public int[] FindOrder_Ver2(int numCourses, int[][] prerequisites) {
        var queue = new Queue<int>();
        var inDegree = new int [numCourses];
        var result = new List<int>();
        var adjacentList = new Dictionary<int, List<int>>();
        var courseCount = 0;

        for(var i = 0; i < numCourses; i++)
        {
            adjacentList.Add(i, new List<int>());
        }

        for(var i = 0; i < prerequisites.Length; i++)
        {
            adjacentList[prerequisites[i][1]].Add(prerequisites[i][0]);
            inDegree[prerequisites[i][0]]++;
        }

        for(var i = 0; i < inDegree.Length; i++)
        {
            if(inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while(queue.Count != 0)
        {
            var i = queue.Dequeue();
            result.Add(i);
            courseCount++;

            for(var j = 0; j < adjacentList[i].Count; j++)
            {
                inDegree[adjacentList[i][j]]--;
                if(inDegree[adjacentList[i][j]] == 0)
                {
                    queue.Enqueue(adjacentList[i][j]);
                }
            }
        }
        
        return courseCount == numCourses ? result.ToArray() : Array.Empty<int>();
    }

    private bool DepthFirstSearch(int i, Dictionary<int, List<int>> adjacentList, int[] visited, Stack<int> stack)
    {
        if (visited[i] == 2)
        {
            return false;
        }

        if (visited[i] == 1)
        {
            return true;
        }

        visited[i] = 1;

        for (var j = 0; j < adjacentList[i].Count; j++)
        {
            if (DepthFirstSearch(adjacentList[i][j], adjacentList, visited, stack))
            {
                return true;
            }
        }

        visited[i] = 2;
        stack.Push(i);

        return false;
    }
}