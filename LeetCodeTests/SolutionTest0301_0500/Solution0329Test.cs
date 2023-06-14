using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0329Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LongestIncreasingPath_Ver1Test(int[][] matrix, int expected)
    {
        var solution = new Solution0329();
        var actual = solution.LongestIncreasingPath_Ver1(matrix);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LongestIncreasingPath_Ver2Test(int[][] matrix, int expected)
    {
        var solution = new Solution0329();
        var actual = solution.LongestIncreasingPath_Ver2(matrix);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 9, 9, 4 },
                new int[] { 6, 6, 8 },
                new int[] { 2, 1, 1 }
            },
            4
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 3, 4, 5 },
                new int[] { 3, 2, 6 },
                new int[] { 2, 2, 1 }
            },
            4
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1 }
            },
            1
        }
    };
}