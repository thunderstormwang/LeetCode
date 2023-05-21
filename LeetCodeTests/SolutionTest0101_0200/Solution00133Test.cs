using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution00133Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PCloneGraph_DFSTest(int[][] adjList, int[][] expectedAdjList)
    {
        // todo BuildGraph
        // todo CheckGraph

        var solution = new Solution0133();
        // var actual = solution.CloneGraph_DFS(root);

        //actual.Should().Equal(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CloneGraph_BFSTest(int[][] adjList, int[][] expectedAdjList)
    {
        // todo BuildGraph
        // todo CheckGraph

        var solution = new Solution0133();
        // var actual = solution.CloneGraph_DFS(root);

        //actual.Should().Equal(expected);
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