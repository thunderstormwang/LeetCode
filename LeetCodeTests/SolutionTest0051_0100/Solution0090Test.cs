using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0090Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SubsetsWithDupTest(int[] inputArray, int[][] expectedArray)
    {
        var solution = new Solution0090();
        var actual = solution.SubsetsWithDup(inputArray);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0 },
            new int[][]
            {
                new int[] { },
                new int[] { 0 }
            }
        },
        new object[]
        {
            new int[] { 0, 1 },
            new int[][]
            {
                new int[] { },
                new int[] { 0 },
                new int[] { 1 },
                new int[] { 0, 1 },
            }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            new int[][]
            {
                new int[] { },
                new int[] { 0 },
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 2 },
                new int[] { 0, 1, 2 }
            }
        },
        new object[]
        {
            new int[] { 1, 1 },
            new int[][]
            {
                new int[] { },
                new int[] { 1 },
                new int[] { 1, 1 }
            }
        },
        new object[]
        {
            new int[] { 1, 1, 1 },
            new int[][]
            {
                new int[] { },
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 1, 1 }
            }
        },
        new object[]
        {
            new int[] { 1, 2, 2 },
            new int[][]
            {
                new int[] { },
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 1, 2 },
                new int[] { 2, 2 },
                new int[] { 1, 2, 2 }
            }
        }
    };
}