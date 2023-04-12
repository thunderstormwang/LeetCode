using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0063Test
{
    [TestCaseSource(nameof(TestCases))]
    public void UniquePathsWithObstacles(int[][] obstacleGrid, int expected)
    {
        var solution = new Solution0063();
        var actual = solution.UniquePathsWithObstacles(obstacleGrid);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 }
            },
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 1, },
                new int[] { 0, 0, }
            },
            1
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 0, }
            },
            1
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0 },
                new int[] { 0 }
            },
            1
        }
    };
}