using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0435Test
{
    [TestCaseSource(nameof(TestCases))]
    public void EraseOverlapIntervalsTest(int[][] intervals, int expected)
    {
        var solution = new Solution0435();
        var actual = solution.EraseOverlapIntervals(intervals);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 }
            },
            1
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 }
            },
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            },
            0
        },
        new object[]
        {
            new int[][]
            {
                new int[] { -52, 31 },
                new int[] { -73, -26 },
                new int[] { 82, 97 },
                new int[] { -65, -11 },
                new int[] { -62, -49 },
                new int[] { 95, 99 },
                new int[] { 58, 95 },
                new int[] { -31, 49 },
                new int[] { 66, 98 },
                new int[] { -63, 2 },
                new int[] { 30, 47 },
                new int[] { -40, -26 }
            },
            7
        }
    };
}