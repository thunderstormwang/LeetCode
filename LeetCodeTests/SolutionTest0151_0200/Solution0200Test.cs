using FluentAssertions;
using LeetCode.Solution0151_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0200Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumIslands_DFSTest(char[][] grid, int expected)
    {
        var solution = new Solution0200();
        var actual = solution.NumIslands_DFS(grid);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void NumIslands_BFSTest(char[][] grid, int expected)
    {
        var solution = new Solution0200();
        var actual = solution.NumIslands_BFS(grid);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[][]
            {
                new char[] { '1', '1', '1', '1', '0' }, 
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' }, 
                new char[] { '0', '0', '0', '0', '0' }
            },
            1
        },
        new object[]
        {
            new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' }, 
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' }, 
                new char[] { '0', '0', '0', '1', '1' }
            },
            3
        }
    };
}