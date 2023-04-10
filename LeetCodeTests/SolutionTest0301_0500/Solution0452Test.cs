using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0452Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ReconstructQueueTest(int[][] points, int expected)
    {
        var solution = new Solution0452();
        var actual = solution.FindMinArrowShots(points);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 10, 16 },
                new int[] { 2, 8 },
                new int[] { 1, 6 },
                new int[] { 7, 12 }
            },
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6 },
                new int[] { 7, 8 }
            },
            4
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 }
            },
            2
        }
    };
}