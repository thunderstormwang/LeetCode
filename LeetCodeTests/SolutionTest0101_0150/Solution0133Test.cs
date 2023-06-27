using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0133Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PCloneGraph_DFSTest(int[][] adjList, int[][] expectedAdjList)
    {
        // todo BuildGraph
        // todo CheckGraph

        var root = Utility.BuildGraphNode(adjList);

        var solution = new Solution0133();
        var actual = solution.CloneGraph_DFS(root);

        Utility.CheckGraphNode(root, actual, new Dictionary<int, GraphNode>(), new Dictionary<int, GraphNode>()).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CloneGraph_BFSTest(int[][] adjList, int[][] expectedAdjList)
    {
        // todo BuildGraph
        // todo CheckGraph
        
        var root = Utility.BuildGraphNode(adjList);

        var solution = new Solution0133();
        var actual = solution.CloneGraph_DFS(root);

        Utility.CheckGraphNode(root, actual, new Dictionary<int, GraphNode>(), new Dictionary<int, GraphNode>()).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 2, 4 },
                new int[] { 1, 3 },
                new int[] { 2, 4 },
                new int[] { 1, 3 }
            },
            new int[][]
            {
                new int[] { 2, 4 },
                new int[] { 1, 3 },
                new int[] { 2, 4 },
                new int[] { 1, 3 }
            }
        },
        new object[]
        {
            null,
            null
        }
    };
}