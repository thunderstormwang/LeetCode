using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0815Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumBusesToDestinationTest(int[][] routes, int source, int target, int expected)
    {
        var solution = new Solution0815();
        var actual = solution.NumBusesToDestination(routes, source, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2, 7 },
                new int[] { 3, 6, 7 },
            },
            1,
            6,
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 7, 12 },
                new int[] { 4, 5, 15 },
                new int[] { 6 },
                new int[] { 15, 19 },
                new int[] { 9, 12, 13 }
            },
            15,
            12,
            -1
        }
    };
}