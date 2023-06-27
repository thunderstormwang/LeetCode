using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0543Test
{
    [TestCaseSource(nameof(TestCases))]
    public void UpdateMatrix_Ver1Test(int[][] mat, int[][] expected)
    {
        var solution = new Solution0543();
        var actual = solution.UpdateMatrix_Ver1(mat);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void UpdateMatrix_Ver2Test(int[][] mat, int[][] expected)
    {
        var solution = new Solution0543();
        var actual = solution.UpdateMatrix_Ver2(mat);

        actual.Should().BeEquivalentTo(expected);
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
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 }
            },
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 }
            },
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 }
            },
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 }
            },
            new int[][]
            {
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 }
            },
        }
    };
}