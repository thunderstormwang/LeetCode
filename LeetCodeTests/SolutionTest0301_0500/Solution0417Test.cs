using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0417Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PacificAtlantic_Ver1Test(int[][] heights, IList<IList<int>> expected)
    {
        var solution = new Solution0417();
        var actual = solution.PacificAtlantic_Ver1(heights);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void PacificAtlantic_Ver2Test(int[][] heights, IList<IList<int>> expected)
    {
        var solution = new Solution0417();
        var actual = solution.PacificAtlantic_Ver2(heights);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2, 2, 3, 5 },
                new int[] { 3, 2, 3, 4, 4 },
                new int[] { 2, 4, 5, 3, 1 },
                new int[] { 6, 7, 1, 4, 5 },
                new int[] { 5, 1, 1, 2, 4 }
            },
            new List<IList<int>>()
            {
                new List<int>() { 0, 4 },
                new List<int>() { 1, 3 },
                new List<int>() { 1, 4 },
                new List<int>() { 2, 2 },
                new List<int>() { 3, 0 },
                new List<int>() { 3, 1 },
                new List<int>() { 4, 0 },
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1 }
            },
            new List<IList<int>>()
            {
                new List<int>() { 0, 0 }
            }
        }
    };
}