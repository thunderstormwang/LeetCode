using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0073Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SetZeroesTest(int[][] matrix, int[][] expected)
    {
        var solution = new Solution0073();
        solution.SetZeroes(matrix);

        matrix.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 },
            },
            new int[][]
            {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 },
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 },
            },
            new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 4, 5, 0 },
                new int[] { 0, 3, 1, 0 },
            }
        }
    };
}