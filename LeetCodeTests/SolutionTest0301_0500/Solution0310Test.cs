using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0310Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumSquares_Ver1Test(int n, int[][] edges, List<int> expected)
    {
        var solution = new Solution0310();
        var actual = solution.FindMinHeightTrees_Ver1(n, edges);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void NumSquares_Ver2Test(int n, int[][] edges, List<int> expected)
    {
        var solution = new Solution0310();
        var actual = solution.FindMinHeightTrees_Ver2(n, edges);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            4,
            new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 1, 3 }
            },
            new List<int> { 1 }
        },
        new object[]
        {
            6,
            new int[][]
            {
                new int[] { 3, 0 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 4 },
            },
            new List<int> { 3, 4 }
        },
        new object[]
        {
            1,
            new int[][] { },
            new List<int> { 0 }
        }
    };
}