using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0994Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SortedSquares(int[][] grid, int expected)
    {
        var solution = new Solution0994();
        var actual = solution.OrangesRotting(grid);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 },
            },
            4
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 },
            },
            -1
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 2 }
            },
            0
        }
    };
}