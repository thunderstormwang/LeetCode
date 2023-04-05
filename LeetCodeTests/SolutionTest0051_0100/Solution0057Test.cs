using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0057Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RotateTest(int[][] intervals, int[] newInterval, int[][] expected)
    {
        var solution = new Solution0057();
        var actual = solution.Insert(intervals, newInterval);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            },
            new int[] { 2, 5 },
            new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 6, 9 }
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 }
            },
            new int[] { 4, 8 },
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 10 },
                new int[] { 12, 16 }
            }
        },
        new object[]
        {
            new int[][] { },
            new int[] { 5, 7 },
            new int[][]
            {
                new int[] { 5, 7 }
            }
        },
    };
}