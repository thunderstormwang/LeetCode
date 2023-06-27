using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution1730Test
{
    [TestCaseSource(nameof(TestCases))]
    public void GetFoodTest(char[][] grid, int expected)
    {
        var solution = new Solution1730();
        var actual = solution.GetFood(grid);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X', 'X', 'X' },
                new char[] { 'X', '*', 'O', 'O', 'O', 'X' },
                new char[] { 'X', 'O', 'O', '#', 'O', 'X' },
                new char[] { 'X', 'X', 'X', 'X', 'X', 'X' },
            },
            3
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X', 'X' },
                new char[] { 'X', '*', 'X', 'O', 'X' },
                new char[] { 'X', 'O', 'X', '#', 'X' },
                new char[] { 'X', 'X', 'X', 'X', 'X', },
            },
            -1
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                new char[] { 'X', '*', 'O', 'X', 'O', '#', 'O', 'X' },
                new char[] { 'X', 'O', 'O', 'X', 'O', 'O', 'X', 'X' },
                new char[] { 'X', 'O', 'O', 'O', 'O', '#', 'O', 'X' },
                new char[] { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' }
            },
            6
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'O', '*' },
                new char[] { '#', 'O' }
            },
            2
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'X', '*' },
                new char[] { '#', 'X' },
            },
            -1
        }
    };
}